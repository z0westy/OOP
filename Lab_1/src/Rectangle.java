public class Rectangle extends Figure{
    private final int x1, y1, x2, y2;

    public Rectangle(int x1, int y1, int x2, int y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    @Override
    public void draw() {
        System.out.printf("Rectangle(x1 = %d, y1 = %d, x2 = %d, y2 = %d)\n", x1, y1, x2, y2);
    }
}
