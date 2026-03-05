public class Circle extends Figure {
    private final int x, y, radius;

    public Circle(int x, int y, int radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    @Override
    public void draw() {
        System.out.printf("Circle(x = %d, y = %d, radius = %d)\n", x, y, radius);
    }
}
