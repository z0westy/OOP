// Class for rectangle
public class Rectangle : Figure
{
    // Class for drawing rectangle
    public class RectDrawing : Drawing
    {
        int x1, y1, x2, y2;

        public RectDrawing(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        public override void Draw(Graphics g, Pen p)
        {
            if (x2 < x1) { (x1, x2) = (x2, x1); }
            if (y2 < y1) { (y1, y2) = (y2, y1); }
            g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
        }
    }

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        drawing = new RectDrawing(x1, y1, x2, y2);
    }
}