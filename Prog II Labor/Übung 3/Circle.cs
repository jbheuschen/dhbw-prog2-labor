namespace Prog_II_Labor.Übung_3;

public class Circle : Shape
{

    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * (radius * radius);
    }
}