using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>();
        Console.WriteLine("Please give a number to save. Type 0 to finish. ");
        int number = -1;
        while (number != 0) 
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                values.Add(number);
            }

        }
        int totalSum = 0;
        foreach (int value in values)
        {
            totalSum += value;
        }
        Console.WriteLine($"The sum of the list is: {totalSum}");

        float average = ((float)totalSum) / values.Count;
        Console.WriteLine($"The average of the list of numbers is: {average}");

        int maximum = values[0];
        foreach (int value in values)
        {
            if (value > maximum)
            {
                maximum = value;
            }
        }
        Console.WriteLine($"The maximum number from the list is: {maximum}");
    }
}