// Class for Ellipse
public class Ellipse : Figure
{
    // Class for drawing ellipse
    public class EllipseDrawing : Drawing
    {
        int x1, y1, x2, y2;

        public EllipseDrawing(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        public override void Draw(Graphics g, Pen p)
        {
            if (x2 < x1) { (x1, x2) = (x2, x1); }
            if (y2 < y1) { (y1, y2) = (y2, y1); }
            g.DrawEllipse(p, new RectangleF(x1, y1, x2 - x1, y2 - y1));
        }
    }

    public Ellipse(int x1, int y1, int x2, int y2)
    {
        drawing = new EllipseDrawing(x1, y1, x2, y2);
    }
}