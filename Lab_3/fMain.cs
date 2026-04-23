using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_2
{
    // Class for main form
    public partial class fMain : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);

        FigureList figures = new FigureList();

        int lastX, lastY;
        bool isDrawing = false;

        // Constructor for main form class. Includes static initialization of figures
        public fMain()
        {
            InitializeComponent();
            addFigureAndUpdate(figures, new Rectangle(10, 10, 50, 74));
            addFigureAndUpdate(figures, new Square(250, 250, 450, 450));
            addFigureAndUpdate(figures, new Triangle(700, 700, 850, 850, 900, 700));
            addFigureAndUpdate(figures, new Ellipse(250, 250, 450, 450));
        }

        // Function for adding figure to list and list box
        private void addFigureAndUpdate(FigureList figures, Figure figure)
        {
            figures.addFigure(figure);
            lbFigures.Items.Add(figure);
        }

        // Event handler for starting using brush
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            g = Graphics.FromHwnd(pbMain.Handle);
            lastX = e.X; lastY = e.Y;
            isDrawing = true;
        }

        // Event handler for using brush
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (tsBtnBrush.Checked && isDrawing)
            {
                g.DrawLine(p, lastX, lastY, e.X, e.Y);
                lastX = e.X; lastY = e.Y;
            }
        }

        // Event handler for stopping using brush
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        // Event handler for updating drawing area
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.drawing.Draw(e.Graphics, p);
            }
        }

        // Event handler for creating line
        private void tsBtnLine_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure();
            if (form.ShowDialog() == DialogResult.OK)
            {
                addFigureAndUpdate(figures, new Line(int.Parse(form.tbFirst.Text),
                        int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                        int.Parse(form.tbFourth.Text)));
                pbMain.Invalidate();
            }
            tsBtnLine.Checked = false;
        }

        // Event handler for creating square
        private void tsBtnSquare_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int x1 = int.Parse(form.tbFirst.Text); int y1 = int.Parse(form.tbSecond.Text);
                int x2 = int.Parse(form.tbThird.Text); int y2 = int.Parse(form.tbFourth.Text);
                if ((x2 <= x1 || y2 <= y1) || x2 - x1 != y2 - y1)
                {
                    MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                addFigureAndUpdate(figures, new Square(x1, y1, x2, y2));
                pbMain.Invalidate();
            }
            tsBtnSquare.Checked = false;
        }

        // Event handler for creating rectangle
        private void tsBtnRectangle_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int x1 = int.Parse(form.tbFirst.Text); int y1 = int.Parse(form.tbSecond.Text);
                int x2 = int.Parse(form.tbThird.Text); int y2 = int.Parse(form.tbFourth.Text);
                if (x2 <= x1 || y2 <= y1)
                {
                    MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                addFigureAndUpdate(figures, new Rectangle(x1, y1, x2, y2));
                pbMain.Invalidate();
            }
            tsBtnRectangle.Checked = false;
        }

        // Event handler for creating circle
        private void tsBtnCircle_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int x1 = int.Parse(form.tbFirst.Text); int y1 = int.Parse(form.tbSecond.Text);
                int x2 = int.Parse(form.tbThird.Text); int y2 = int.Parse(form.tbFourth.Text);
                if ((x2 <= x1 || y2 <= y1) || x2 - x1 != y2 - y1)
                {
                    MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                addFigureAndUpdate(figures, new Circle(x1, y1, x2, y2));
                pbMain.Invalidate();
            }
            tsBtnCircle.Checked = false;
        }

        // Event handler for creating ellipse
        private void tsBtnEllipse_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateFigure form = new fCreateFigure();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int x1 = int.Parse(form.tbFirst.Text); int y1 = int.Parse(form.tbSecond.Text);
                int x2 = int.Parse(form.tbThird.Text); int y2 = int.Parse(form.tbFourth.Text);
                if (x2 <= x1 || y2 <= y1)
                {
                    MessageBox.Show("Ошибка создания фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                addFigureAndUpdate(figures, new Ellipse(x1, y1, x2, y2));
                pbMain.Invalidate();
            }
            tsBtnEllipse.Checked = false;
        }

        // Event handler for creating triangle
        private void tsBtnTriangle_Click(object sender, EventArgs e)
        {
            tsBtnBrush.Checked = false;
            fCreateTriangle form = new fCreateTriangle();
            if (form.ShowDialog() == DialogResult.OK)
            {
                addFigureAndUpdate(figures, new Triangle(int.Parse(form.tbFirst.Text),
                    int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                    int.Parse(form.tbFourth.Text), int.Parse(form.tbFifth.Text),
                    int.Parse(form.tbSixth.Text)));
                pbMain.Invalidate();
            }
            tsBtnTriangle.Checked = false;
        }

        // Event handler for clearing drawing area
        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            figures = new FigureList();
            pbMain.Invalidate();
            lbFigures.Items.Clear();
            tsBtnClear.Checked = false;
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

        // Function for modifying figure (except triangle)
        private void modifyFigure(Figure figure)
        {
            fCreateFigure form = new fCreateFigure();
            form.Text = "Изменение фигуры";
            form.tbFirst.Text = figure.drawing.x1.ToString(); form.tbSecond.Text = figure.drawing.y1.ToString();
            form.tbThird.Text = figure.drawing.x2.ToString(); form.tbFourth.Text = figure.drawing.y2.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!figure.Modify([int.Parse(form.tbFirst.Text), int.Parse(form.tbSecond.Text), 
                        int.Parse(form.tbThird.Text), int.Parse(form.tbFourth.Text)]))
                {
                    MessageBox.Show("Ошибка изменения фигуры", "Указаны некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pbMain.Invalidate();
            }
        }

        // Function for modifying triangle
        private void modifyTriangle(Figure figure)
        {
            fCreateTriangle form = new fCreateTriangle();
            form.Text = "Изменение фигуры";
            form.tbFirst.Text = figure.drawing.x1.ToString(); form.tbSecond.Text = figure.drawing.y1.ToString();
            form.tbThird.Text = figure.drawing.x2.ToString(); form.tbFourth.Text = figure.drawing.y2.ToString();
            form.tbFifth.Text = figure.drawing.x3.ToString(); form.tbSixth.Text = figure.drawing.y3.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!figure.Modify([int.Parse(form.tbFirst.Text), int.Parse(form.tbSecond.Text),
                        int.Parse(form.tbThird.Text), int.Parse(form.tbFourth.Text),
                        int.Parse(form.tbFifth.Text), int.Parse(form.tbSixth.Text)]))
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
            if (figure is Triangle) 
            {
                modifyTriangle(figure);
            }
            else { modifyFigure(figure); }
        }
    }
}
