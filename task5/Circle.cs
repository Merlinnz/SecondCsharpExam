public class Circle
{
    private double Radius=2;
    private double Pi=3.14;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle()
    {

    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public double GetDiameter()
    {
        return 2 * Radius;
    }
    public double GetCircumference()
    {
        return 2 * Pi;
    }
    public double GetRadius()
    {
        return Radius;
    }
}