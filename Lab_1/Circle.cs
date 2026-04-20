public class Circle : Figure
{
    double x, y, r;
    public Circle(double x, double y, double r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public override void drawFigure()
    {
        Console.WriteLine($"Circle({x}, {y}, {r})");
    }
}