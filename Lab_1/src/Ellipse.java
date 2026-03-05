public class Ellipse extends Figure{
    private final int x, y, a, b;

    public Ellipse(int x, int y, int a, int b) {
        this.x = x;
        this.y = y;
        this.a = a;
        this.b = b;
    }

    @Override
    public void draw() {
        System.out.printf("Ellipse(x = %d, y = %d, a = %d, b = %d)\n", x, y, a, b);
    }
}
