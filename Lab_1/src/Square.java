public class Square extends Figure{
    private final int x, y, a;

    public Square(int x, int y, int a) {
        this.x = x;
        this.y = y;
        this.a = a;
    }

    @Override
    public void draw() {
        System.out.printf("Square(x = %d, y = %d, a = %d)\n", x, y, a);
    }
}
