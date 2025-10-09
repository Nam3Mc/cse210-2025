public class Circle : Shape
{
    private double _radious;
    public Circle(string color, double radius) : base(color)
    {
        _radious = radius;
    }
    public override double GetArea()
    {
        return _radious * _radious * Math.PI;
    }
}