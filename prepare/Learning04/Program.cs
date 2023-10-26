using System;

public class Program
{
    public static void Main()
    {
        Assignment one = new Assignment("Robert Cunningham", "Calculus");
        Console.WriteLine(one.GetSummary());

        MathAssignment two = new MathAssignment("James Cowell", "Matricies", "12.1", "13-24");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomework());

        WritingAssignment three = new WritingAssignment("James Douglas", "Economics", "The Long Term Effects of The Great Depression");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}