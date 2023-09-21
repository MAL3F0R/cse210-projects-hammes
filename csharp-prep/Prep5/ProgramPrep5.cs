using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string inputName = PromptUserName();
        int inputNumber = PromptUserNumber();
        int square = SquareNumber(inputNumber);
        DisplayResult(inputName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int squaredValue = number * number;

        return squaredValue;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}   

