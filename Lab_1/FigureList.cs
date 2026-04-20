public class FigureList
{
    public List<Figure> figures = new List<Figure>();

    public void addFigure(Figure f) { figures.Add(f); }
    public void removeFigure(Figure f) { figures.Remove(f); }
}