namespace Group_C;

public class Shapes
{
    public static ImplicitGeometry Tshape()
    {
        Rectangle rectangle4 = new Rectangle(20, 0, 25, 50);
        Rectangle rectangle5 = new Rectangle(20, 20, 70, 30);
        Union tShape = new Union(rectangle4, rectangle5);
        return tShape;
    }

    public static ImplicitGeometry Ushape()
    {
        var circle1 = new Circle(50, 85, 25);
        var rectangle1 = new Rectangle(20, 60, 50, 110);
        var circle2 = new Circle(50, 85, 15);
        var rectangle2 = new Rectangle(20, 70, 50, 100);
        var ushape = new Union(rectangle1, circle1);
        var uShape1 = new Union(rectangle2, circle2);
        var ushape3 = new Difference(ushape, uShape1);
        return ushape3;
    }

    public static ImplicitGeometry Mshape()
    {
        var circle1 = new Circle(20, 150, 20);
        var circle2 = new Circle(20, 150, 15);

        var rectangle1 = new Rectangle(0, 120, 74, 130);
        var rectangle2 = new Rectangle(0, 170, 74, 180);
        var rectangle3 = new Rectangle(0, 120, 18, 180);
        var rectangles = new Union(rectangle1, rectangle2);
        var circles = new Difference(circle1, circle2);
        var unions = new Union(rectangles, circles);
        var unions2 = new Difference(unions, rectangle3);
        return unions2;
    }
}