public class Main {
    public static void main(String[] args) {
        FigureList figureList = new FigureList();
        figureList.Add(new Circle(20, 30, 10));
        figureList.Add(new Ellipse(30, 15, 5, 10));
        figureList.Add(new Line(0, 0, 100, 0));
        figureList.Add(new Rectangle(10, 10, 50, 50));
        figureList.Add(new Square(20, 20, 50));
        figureList.Add(new Triangle(20, 20, 40, 40, 30, 50));

        figureList.drawAll();
    }
}
