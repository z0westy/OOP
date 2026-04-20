FigureList figures =  new FigureList();
figures.addFigure(new Circle(5, 10, 5));
figures.addFigure(new Ellipse(0, -5, 5, 10));
figures.addFigure(new Line(-25, 5, 70, 100));
figures.addFigure(new Rectangle(-50, -50, 50, 50));
figures.addFigure(new Square(20, 15, 20));
figures.addFigure(new Triangle(10, 10, 20, 20, 30, 10));

foreach(Figure f in figures.figures)
{
    f.drawFigure();
}