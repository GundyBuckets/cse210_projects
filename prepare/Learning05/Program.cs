using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        shapes.Add(new Circle("blue", 5.6));
        shapes.Add(new Square("yellow", 8.23));
        shapes.Add(new Rectangle("pink", 4.678, 3.4));

        foreach (Shape s in shapes) {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}