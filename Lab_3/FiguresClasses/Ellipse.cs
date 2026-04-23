// Class for Ellipse
[Serializable]
public class Ellipse : Figure
{
    // Class for drawing ellipse
    [Serializable]
    public class EllipseDrawing : Drawing
    {
        public EllipseDrawing(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        // Overridden function for drawing ellipse
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawEllipse(p, new RectangleF(x1, y1, x2 - x1, y2 - y1));
        }
    }

    public Ellipse(int x1, int y1, int x2, int y2)
    {
        drawing = new EllipseDrawing(x1, y1, x2, y2);
    }

    // Overridden function for modifying circle
    public override bool Modify(int[] coords)
    {
        if (coords[2] <= coords[0] || coords[3] <= coords[1]) { return false; }
        drawing.x1 = coords[0]; drawing.y1 = coords[1];
        drawing.x2 = coords[2]; drawing.y2 = coords[3];
        return true;
    }
}