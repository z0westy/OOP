// Class for figure list
[Serializable]
public class FigureList
{
    public int Count = 0;
    public List<Figure> figures = new List<Figure>();

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

    // Function for adding figure to list
    public void addFigure(Figure f) 
    { 
        figures.Add(f);
        Count++;
    }

    // Function for removing figure from list by value
    public void removeFigure(Figure f) 
    { 
        figures.Remove(f);
        Count--;
    }

    // Function for removing figure from list by index
    public void removeFigureAt(int index)
    {
        figures.RemoveAt(index);
        Count--;
    }
}