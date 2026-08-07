using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("green", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("red", 4, 5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("blue", 6);
        shapes.Add(circle1);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape's area is {area}.");
        }
    }
}