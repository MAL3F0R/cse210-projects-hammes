using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage for your class? ");
        string value = Console.ReadLine();
        int percent = int.Parse(value);
        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your current grade is {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("Your grade is at a passing level.");
        }
        else
        {
            Console.WriteLine("Your grade is not at a passing level.");
        }
    }
}