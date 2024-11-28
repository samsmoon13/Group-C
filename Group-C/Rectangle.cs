namespace Group_C;

public class Rectangle:ImplicitGeometry
{
   private double x1;
   private double y1;
   private double x2;
   private double y2;

   public Rectangle(double x1, double y1, double x2, double y2)
   {
      this.x1 = x1;
      this.y1 = y1;
      this.x2 = x2;
      this.y2 = y2;
   }

   public override bool IsInside(double x, double y)
   {
      return ((x >= x1 && x <= x2) && (y >= y1 && y <= y2));
   }
}