using System;

internal class Rectangle : Shape
{
    private double widths;
    private double lengths;

    public Rectangle(string color, double width, double length) : base (color)
    {
        lengths = length;
        widths = width;
    }

    public override double GetArea()
    {
        double areaR = lengths * widths;
        return areaR;
    }
}