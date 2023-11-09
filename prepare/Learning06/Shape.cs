using System;

internal abstract class Shape
{
    private string color;

    internal Shape(string givenColor)
    {
        color = givenColor;
    }

    public abstract double GetArea();

    internal string GetColor()
    {
        return color;
    }

    internal void SetColor(string inputColor)
    {
        color = inputColor;
    }

}