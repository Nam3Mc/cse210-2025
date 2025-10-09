using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 7);
        Rectangle shape2 = new Rectangle("Gray", 20, 13);
        Circle s3 = new Circle("Red", 9);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(s3);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"{color}, {area}");
        }    }
}