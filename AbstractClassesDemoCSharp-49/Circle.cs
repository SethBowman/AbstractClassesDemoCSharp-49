namespace AbstractClassesDemoCSharp_49;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}