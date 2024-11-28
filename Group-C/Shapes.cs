namespace Group_C;

public static class Shapes
{
    public static ImplicitGeometry TShape()
    {
        var rectangle4 = new Rectangle(5, 5, 10, 25);
        var rectangle5 = new Rectangle(10, 12.5, 25, 17.5);
        var tShape = new Union(rectangle4, rectangle5);
        return tShape;
    }

    public static ImplicitGeometry UShape()
    {
        var circle1 = new Circle(15, 40, 10);
        var rectangle1 = new Rectangle(5, 30, 15, 50);
        var circle2 = new Circle(15, 40, 5);
        var rectangle2 = new Rectangle(5, 35, 15, 45);
        var uShape0 = new Union(rectangle1, circle1);
        var uShape1 = new Union(rectangle2, circle2);
        var uShape2 = new Difference(uShape0, uShape1);
        return uShape2;
    }

    public static ImplicitGeometry MShape()
    {
        var circle1 = new Circle(0, 67.3, 13);
        var circle2 = new Circle(0, 67.3, 10);

        var rectangle1 = new Rectangle(5, 55, 25, 59);
        var rectangle2 = new Rectangle(5, 75, 25, 82);
        var rectangle3 = new Rectangle(0, 55, 4, 82);
        var rectangles = new Union(rectangle1, rectangle2);
        var circles = new Difference(circle1, circle2);
        var unions = new Union(rectangles, circles);
        var unions2 = new Difference(unions, rectangle3);
        return unions2;
    }
}