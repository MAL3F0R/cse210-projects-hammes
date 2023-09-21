using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());        

            if (number > guess)
            {
                Console.WriteLine("Go higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Go lower");
            }
            else
            {
                Console.WriteLine("You guessed the right number!");
            }
        
        }
    }
}