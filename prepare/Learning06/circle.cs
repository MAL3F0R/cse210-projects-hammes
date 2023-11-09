using System;

internal class Circle : Shape
{
    private double radii;
    internal Circle(double radius, string color) : base(color)
    {
        radii = radius;
    }

    public override double GetArea()
    {
        double circleArea = radii * radii * Math.PI;
        return circleArea;
    }
}