// Class for line
[Serializable]
public class Line : Figure
{
    // Class for drawing line
    [Serializable]
    public class LineDrawing : Drawing
    {
        public LineDrawing(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        // Overridden function for drawing line
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, x1, y1, x2, y2);
        }
    }

    public Line(int x1, int y1, int x2, int y2)
    {
        drawing = new LineDrawing(x1, y1, x2, y2);
    }

    // Overridden function for modifying line
    public override bool Modify(int[] coords)
    {
        drawing.x1 = coords[0]; drawing.y1 = coords[1];
        drawing.x2 = coords[2]; drawing.y2 = coords[3];
        return true;
    }
}