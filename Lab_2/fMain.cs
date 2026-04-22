using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
            figures.addFigure(new Rectangle(10, 10, 50, 74));
            figures.addFigure(new Square(250, 250, 450, 450));
            figures.addFigure(new Triangle(700, 700, 850, 850, 900, 700));
            figures.addFigure(new Ellipse(250, 250, 450, 450));
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
                figures.addFigure(new Line(int.Parse(form.tbFirst.Text),
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
                if (x2 - x1 != y2 - y1) { return; }

                figures.addFigure(new Square(int.Parse(form.tbFirst.Text),
                    int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                    int.Parse(form.tbFourth.Text)));
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
                figures.addFigure(new Rectangle(int.Parse(form.tbFirst.Text),
                    int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                    int.Parse(form.tbFourth.Text)));
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
                figures.addFigure(new Circle(int.Parse(form.tbFirst.Text),
                    int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                    int.Parse(form.tbFourth.Text)));
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
                figures.addFigure(new Ellipse(int.Parse(form.tbFirst.Text),
                    int.Parse(form.tbSecond.Text), int.Parse(form.tbThird.Text),
                    int.Parse(form.tbFourth.Text)));
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
                figures.addFigure(new Triangle(int.Parse(form.tbFirst.Text),
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
            tsBtnClear.Checked = false;
        }
    }
}
