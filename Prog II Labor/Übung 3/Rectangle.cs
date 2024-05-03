namespace Prog_II_Labor.Übung_3;

public class Rectangle : Shape
{

    public double a, b;

    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    
    public override double CalculateArea()
    {
        return a * b;
    }
}