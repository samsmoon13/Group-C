namespace Group_C;

public class Circle:ImplicitGeometry
{
    private double xCenter;
    private double yCenter;
    private double radius;
    
    public Circle(double x, double y, double radius)
    {
      this.xCenter = x;
      this.yCenter = y;
      this.radius = radius;
    }
    
    public override bool IsInside(double x, double y)
    {
        double dx = x - xCenter;
        double dy = y - yCenter;
        double distanceSquared = dx * dx + dy * dy;
        return Math.Sqrt(distanceSquared) <= radius;
    }
    
}