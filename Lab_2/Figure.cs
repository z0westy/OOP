using System;

// Abstract class for other figures
abstract public class Figure
{
    // Abstract class for drawing figure
    abstract public class Drawing
    {
        abstract public void Draw(Graphics g, Pen p);
    }
    public Drawing drawing;
}
