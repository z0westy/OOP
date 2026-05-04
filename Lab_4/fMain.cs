using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_2
{
    // Class for main form
    public partial class fMain : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);

        FigureList figures = new FigureList();
        List<Type> importedTypes = new List<Type> { typeof(Rectangle), typeof(Square), typeof(Circle),
                                               typeof(Line), typeof(Ellipse), typeof(Triangle) };

        int brushX, brushY;
        bool isDrawingBrush = false;

        // Constructor for main form class. Includes static initialization of figures
        public fMain()
        {
            InitializeComponent();
            addFigureAndUpdate(figures, new Rectangle(new int[] { 10, 10, 50, 74 }));
            addFigureAndUpdate(figures, new Square(new int[] { 250, 250, 450, 450 }));
            addFigureAndUpdate(figures, new Triangle(new int[] { 700, 700, 850, 850, 900, 700 }));
            addFigureAndUpdate(figures, new Ellipse(new int[] { 250, 250, 450, 450 }));
        }

        // Event handler for starting using brush
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            g = Graphics.FromHwnd(pbMain.Handle);
            brushX = e.X; brushY = e.Y;
            isDrawingBrush = true;
        }

        // Event handler for using brush
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (tsBtnBrush.Checked && isDrawingBrush)
            {
                g.DrawLine(p, brushX, brushY, e.X, e.Y);
                brushX = e.X; brushY = e.Y;
            }
        }

        // Event handler for stopping using brush
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawingBrush = false;
        }

        // Function for adding figure to list and list box
        private void addFigureAndUpdate(FigureList figures, Figure figure)
        {
            figures.addFigure(figure);
            lbFigures.Items.Add(figure);
        }

        // Function for modifying figure
        private void modifyFigure(Figure figure)
        {
            fCreateFigure form = new fCreateFigure(figure.coords.Length);
            form.Text = "Изменение фигуры";

            for (int i = 0; i < figure.coords.Length; i++)
            {
                form.textBoxes[i].Text = figure.coords[i].ToString();
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!figure.Modify(form.getTextBoxesValues()))
                {
                    MessageBox.Show("Ошибка изменения фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pbMain.Invalidate();
            }
        }

        // Event handler for selecting figure and modifying it
        private void lbFigures_DoubleClick(object sender, EventArgs e)
        {
            Figure figure = figures[lbFigures.SelectedIndex];
            modifyFigure(figure);
        }

        // Event handler for removing figure from list and list box
        private void lbFigures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lbFigures.SelectedIndex > -1)
            {
                figures.removeFigureAt(lbFigures.SelectedIndex);
                pbMain.Invalidate();
                lbFigures.Items.RemoveAt(lbFigures.SelectedIndex);
            }
        }

        // Event handler for updating drawing area
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.drawing.Draw(e.Graphics, p, f.coords);
            }
        }

        // Function for creating any figure
        private void createFigure(Type figureType, string[] placeholders, 
            int coordsLen, ToolStripButton tsbElem)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure(coordsLen, placeholders);

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Figure figure = (Figure)Activator.CreateInstance(figureType, form.getTextBoxesValues());
                if (figure.isValidCoords(figure.coords))
                {
                    addFigureAndUpdate(figures, figure);
                    pbMain.Invalidate();
                }
                else
                {
                    MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tsbElem.Checked = false;
        }

        // Event handler for creating line
        private void tsBtnLine_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Line), Line.placeholders, Line.numCoords, tsBtnLine);
        }

        // Event handler for creating square
        private void tsBtnSquare_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Square), Square.placeholders, Square.numCoords, tsBtnSquare);
        }

        // Event handler for creating rectangle
        private void tsBtnRectangle_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Rectangle), Rectangle.placeholders, Rectangle.numCoords, tsBtnRectangle);
        }

        // Event handler for creating circle
        private void tsBtnCircle_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Circle), Circle.placeholders, Circle.numCoords, tsBtnCircle);
        }

        // Event handler for creating ellipse
        private void tsBtnEllipse_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Ellipse), Ellipse.placeholders, Ellipse.numCoords, tsBtnEllipse);
        }

        // Event handler for creating triangle
        private void tsBtnTriangle_Click(object sender, EventArgs e)
        {
            createFigure(typeof(Triangle), Triangle.placeholders, Triangle.numCoords, tsBtnTriangle);
        }

        // Event handler for clearing drawing area
        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            lbFigures.Items.Clear();
            figures = new FigureList();
            pbMain.Invalidate();
            tsBtnClear.Checked = false;
        }

        // Event handler for binary deserialisation
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdMain.FileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    figures = (FigureList)formatter.Deserialize(fs);
                }
                pbMain.Invalidate();
            }
        }

        // Event handler for binary serialisation
        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (sfdMain.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfdMain.FileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, figures);
                }
            }
        }
        
        // Function for importing plugin (DLL)
        private void tsmiImportPlugin_Click(object sender, EventArgs e)
        {
            if (ofdImportPlugin.ShowDialog() != DialogResult.OK) { return; }

            // Loading type
            Assembly asm = Assembly.LoadFrom(ofdImportPlugin.FileName);

            // Getting type of figure
            Type t = asm.GetTypes()[0];

            if (importedTypes.Contains(t)) { return;  }

            importedTypes.Add(t);

            // Getting field with number of coords for figure
            FieldInfo? f = t.GetField("numCoords");
            int numCoords = (int)f.GetValue(null);

            FieldInfo? f_2 = t.GetField("placeholders");
            string[] placeholders = (string[])f_2.GetValue(null);

            // Changing GUI after adding new type of figure
            ToolStripButton button = new ToolStripButton();
            button.ToolTipText = t.ToString();
            button.Image = imMain.Images[0];
            tsMain.Items.Insert(tsMain.Items.Count - 2, button);
            tsMain.Items.Insert(tsMain.Items.Count - 2, new ToolStripSeparator());

            // Setting event handler for creating figure
            button.Click += (object sender, EventArgs e) => 
                createFigure(t, placeholders, numCoords, button);
        }
    }
}
