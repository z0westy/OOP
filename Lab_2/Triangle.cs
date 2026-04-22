// Class for triangle
public class Triangle : Figure
{
    // Class for drawing triangle
    public class TriangleDrawing : Drawing
    {
        int x1, y1, x2, y2, x3, y3;

        public TriangleDrawing(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
            this.x3 = x3; this.y3 = y3;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLines(p, new PointF(x1, y1), new PointF(x2, y2), 
                new PointF(x3, y3), new PointF(x1, y1));
        }
    }

    public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        drawing = new TriangleDrawing(x1, y1, x2, y2, x3, y3);
    }
}