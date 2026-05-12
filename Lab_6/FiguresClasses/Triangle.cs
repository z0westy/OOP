// Class for triangle
using static Figure;

[Serializable]
public class Triangle : Figure
{
    public static new int numCoords = 6;
    public static new string[] placeholders = { "x_1", "y_1", "x_2", "y_2", "x_3", "y_3" };

    // Class for drawing triangle
    [Serializable]
    public class TriangleDrawing : Drawing
    {
        // Overridden function for drawing triangle
        public override void Draw(Graphics g, Pen p, int[] new_coords)
        {
            int x1 = new_coords[0]; int y1 = new_coords[1];
            int x2 = new_coords[2]; int y2 = new_coords[3];
            int x3 = new_coords[4]; int y3 = new_coords[5];
            g.DrawLines(p, new PointF(x1, y1), new PointF(x2, y2), 
                new PointF(x3, y3), new PointF(x1, y1));
        }
    }

    public Triangle(int[] new_coords)
    {
        drawing = new TriangleDrawing();
        coords = new_coords;
    }

    // Overridden function for validating coords
    public override bool isValidCoords(int[] new_coords)
    {
        return true;
    }

    // Overridden function for modifying triangle
    public override bool Modify(int[] new_coords)
    {
        if (!isValidCoords(new_coords)) { return false; }
        coords = new_coords;
        return true;
    }
}