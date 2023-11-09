using System;

internal class Square : Shape
{
    private double sides;

    internal Square(string color, double side) : base(color)
    {
        sides = side;
    }

    public override double GetArea()
    {
        double area = sides * sides;
        return area;
    }
}