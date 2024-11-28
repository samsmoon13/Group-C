namespace Group_C;

public abstract class Operation : ImplicitGeometry
{
    public ImplicitGeometry operand1;
    public ImplicitGeometry operand2;

    public Operation(ImplicitGeometry operand1, ImplicitGeometry operand2)
    {
        this.operand1 = operand1;
        this.operand2 = operand2;
    }
}