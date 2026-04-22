// Class for figure list
public class FigureList
{
    public int Count = 0;
    private List<Figure> figures = new List<Figure>();

    public IEnumerator<Figure> GetEnumerator()
    {
        for (int i = 0; i < figures.Count; i++)
        {
            yield return figures[i];
        }
    }

    public Figure this[int i]
    {
        get => figures[i];
    }

    public void addFigure(Figure f) 
    { 
        figures.Add(f);
        Count++;
    }

    public void removeFigure(Figure f) 
    { 
        figures.Remove(f);
        Count--;
    }
}