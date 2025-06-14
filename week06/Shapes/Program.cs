using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle("Red", 5.0),
            new Rectangle("Blue", 4.0, 6.0),
            new Square("Green", 3.0)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}