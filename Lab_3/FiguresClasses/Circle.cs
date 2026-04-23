// Class for circle
[Serializable]
public class Circle : Ellipse
{
    // Class for drawing circle
    [Serializable]
    public class CircleDrawing : EllipseDrawing
    {
        public CircleDrawing(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
    }

    public Circle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

    // Overridden function for modifying circle
    public override bool Modify(int[] coords)
    {
        if ((coords[2] <= coords[0] || coords[3] <= coords[1]) ||
            coords[2] - coords[0] != coords[3] - coords[1]) { return false; }
        drawing.x1 = coords[0]; drawing.y1 = coords[1];
        drawing.x2 = coords[2]; drawing.y2 = coords[3];
        return true;
    }
}