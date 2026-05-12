using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

/*
  Паттерны:
    Адаптер
    Синглтон (одиночка)
    Мост (Figure + drawing)
    Шаблонный метод
    Посетитель (плагины для экспорта и импорта) 
*/

namespace Lab_2
{
    // Class for main form
    public partial class fMain : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);

        Logger logger;

        FigureList figures = new FigureList();
        List<Type> importedFigureTypes = new List<Type> { typeof(Rectangle), typeof(Square), typeof(Circle),
                                               typeof(Line), typeof(Ellipse), typeof(Triangle) };
        List<Type> importedFunctionTypes = new List<Type>();

        int brushX, brushY;
        bool isDrawingBrush = false;

        // Constructor for main form class. Includes static initialization of figures
        public fMain()
        {
            InitializeComponent();

            Logger.path = @"C:\Users\Prometey\Desktop\ООП\Lab_6\plugins\logger.py";
            Logger.method = "file";
            Logger.file = "logs.txt";
            logger = Logger.getLogger();
            logger.clearLogs();

            addToList(figures, new Rectangle(new int[] { 10, 10, 50, 74 }));
            addToList(figures, new Square(new int[] { 250, 250, 450, 450 }));
            addToList(figures, new Triangle(new int[] { 700, 700, 850, 850, 900, 700 }));
            addToList(figures, new Ellipse(new int[] { 250, 250, 450, 450 }));
        }

        // Function for adding a figure to list and logging it
        private void addToList(FigureList figureList, Figure figure)
        {
            figureList.addFigure(figure);
            logger.printLog($"В список добавлена новая фигура: {figure.GetType().Name}:" +
                $" [{string.Join(", ", figure.coords)}]\n");
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

        // Function for modifying figure
        private void modifyFigure(Figure figure)
        {
            fCreateFigure form = new fCreateFigure(figure.coords.Length);
            form.Text = "Изменение фигуры";

            for (int i = 0; i < figure.coords.Length; i++)
            {
                form.textBoxes[i].Text = figure.coords[i].ToString();
            }

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (!figure.Modify(form.getTextBoxesValues()))
                {
                    MessageBox.Show("Ошибка изменения фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                logger.printLog($"Изменена фигура: {figure.GetType().Name}:" +
                                $" [{string.Join(", ", figure.coords)}]\n");
                pbMain.Invalidate();
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("Ошибка изменения фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                logger.printLog($"Из списка удалена фигура: {figures[lbFigures.SelectedIndex].GetType().Name}:" +
                                $" [{string.Join(", ", figures[lbFigures.SelectedIndex].coords)}]\n");
                figures.removeFigureAt(lbFigures.SelectedIndex);
                pbMain.Invalidate();
            }
        }

        // Event handler for updating drawing area
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            lbFigures.Items.Clear();
            foreach (Figure f in figures)
            {
                f.drawing.Draw(e.Graphics, p, f.coords);
                lbFigures.Items.Add(f);
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
                    addToList(figures, figure);
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
            tsBtnClear.Checked = false;
            figures.removeAllFigures();
            logger.printLog($"Очищен список с фигурами!\n");
            pbMain.Invalidate();
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
                logger.printLog($"Произошла десериализация списка фигур по пути: {ofdMain.FileName}\n");
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
                logger.printLog($"Произошла сериализация списка фигур по пути: {sfdMain.FileName}\n");
            }
        }

        // Function for importing plugin (DLL) with figure
        private void tsmiImportFigure_Click(object sender, EventArgs e)
        {
            if (ofdImportPlugin.ShowDialog() != DialogResult.OK) { return; }

            // Loading type
            Assembly asm = Assembly.LoadFrom(ofdImportPlugin.FileName);

            // Getting type of figure
            Type t = asm.GetTypes()[0];

            if (importedFigureTypes.Contains(t)) { return; }
            importedFigureTypes.Add(t);

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

            logger.printLog($"Импортирован плагин с новой фигурой: {t.Name} по пути {ofdImportPlugin.FileName}\n");
        }

        // Function for importing plugin (DLL) with a new function
        private void tsmiImportFunction_Click(object sender, EventArgs e)
        {
            if (ofdImportPlugin.ShowDialog() != DialogResult.OK) { return; }

            // Loading type
            Assembly asm = Assembly.LoadFrom(ofdImportPlugin.FileName);

            // Getting type of main class
            Type t = asm.GetTypes()[0];

            if (importedFunctionTypes.Contains(t)) { return; }
            importedFunctionTypes.Add(t);

            // Getting main static method
            MethodInfo method = t.GetMethods()[0];

            // Invoking this method
            method.Invoke(null, new object[] { this, pbMain, tsmiMenu, figures });

            logger.printLog($"Импортирован функциональный плагин: {t.Name} по пути {ofdImportPlugin.FileName}\n");
        }
    }
}
