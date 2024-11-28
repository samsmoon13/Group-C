namespace Group_C;

public class Difference:Operation
{
    public Difference(ImplicitGeometry operand1, ImplicitGeometry operand2) : base(operand1, operand2)
    {
    }
    
    public override bool IsInside(double x, double y)
    {
        return (operand1.IsInside(x,y) && !operand2.IsInside(x,y));
    }
    
}