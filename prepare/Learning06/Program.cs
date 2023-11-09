using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle firstShape = new Rectangle("Grey", 3, 6);
        shapes.Add(firstShape);

        Circle secondShape = new Circle(4, "Red");
        shapes.Add(secondShape);

        Square thirdShape = new Square("Blue", 5);
        shapes.Add(thirdShape);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"Your shape is  the color: {color}, and has an area of {area}.");
        }
    }
}