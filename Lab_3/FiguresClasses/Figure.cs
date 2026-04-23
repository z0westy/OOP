// Abstract class for other figures
[Serializable]
abstract public class Figure
{
    // Abstract class for drawing figure
    [Serializable]
    abstract public class Drawing
    {
        public int x1, y1, x2, y2, x3, y3;

        // Abstract function for drawing figure
        abstract public void Draw(Graphics g, Pen p);
    }
    public Drawing drawing;

    // Abstract function for modifying figure
    abstract public bool Modify(int[] coords);
}
