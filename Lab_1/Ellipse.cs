public class Ellipse : Figure
{
    double x, y, a, b;
    public Ellipse(double x, double y, double a, double b)
    {
        this.x = x; this.y = y;
        this.a = a; this.b = b;
    }

    public override void drawFigure()
    {
        Console.WriteLine($"Ellipse({x}, {y}, {a}, {b})");
    }
}