namespace Group_C;

public class Intersection:Operation
{
    public Intersection(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2)
    {
    }

    public override bool IsInside(double x, double y)
    {
        return (operand1.IsInside(x, y) && operand2.IsInside(x, y));
    }
}