import java.util.ArrayList;

public class FigureList {
    ArrayList<Figure> figureList = new ArrayList<>();

    public void Add(Figure figure) {
        figureList.add(figure);
    }

    public void drawAll() {
        for (Figure figure: figureList) {
            figure.draw();
        }
    }
}
