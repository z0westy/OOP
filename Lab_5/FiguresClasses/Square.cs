// Class for square
[Serializable]
public class Square : Rectangle
{
    public static new int numCoords = 4;
    public static new string[] placeholders = { "x_1", "y_1", "x_2", "y_2" };

    // Class for drawing rectangle
    [Serializable]
    public class SquareDrawing : RectDrawing { }

    public Square(int[] new_coords) : base(new_coords) { }

    // Overridden function for validating coords
    public override bool isValidCoords(int[] new_coords)
    {
        int x1 = new_coords[0]; int y1 = new_coords[1];
        int x2 = new_coords[2]; int y2 = new_coords[3];
        if ((x2 <= x1 || y2 <= y1) || x2 - x1 != y2 - y1)
        {
            return false;
        }
        return true;
    }

    // Overridden function for modifying square
    public override bool Modify(int[] new_coords)
    {
        if (!isValidCoords(new_coords)) { return false; }
        coords = new_coords;
        return true;
    }
}