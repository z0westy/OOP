public class Square : Figure
{
    double x, y, a;
    public Square(double x, double y, double a)
    {
        this.x = x;
        this.y = y;
        this.a = a;
    }

    public override void drawFigure()
    {
        Console.WriteLine($"Square({x}, {y}, {a})");
    }
}