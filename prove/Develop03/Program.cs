using System;
using System.Runtime.InteropServices;

class Program
{
    static int displayConsole()
    {
        Console.WriteLine(@"Welcome to the BOM scripture memorizer!
1. Display scriptures
2. Quit
Your input: ");
        try
        {
            int userChoice = Int32.Parse(Console.ReadLine());
            return (userChoice);
        }
        catch(FormatException)
        {
            Console.WriteLine("Improper value passed to Parse for user choice");
            return(0);
        }
    }

    static void Main(string[] args)
    {
        bool keepLooping = true;
        while (keepLooping == true)
        {
            int selection = displayConsole();
            if (selection == 1) 
            {
                Console.Clear();
                Random random = new Random();
                int randomNumber = random.Next(1,4);
                string verse = Scripture.generateScripture(randomNumber);
                string refname = Referenece.getReference(randomNumber);
                Console.WriteLine($"{refname}: {verse}");
                Word.MakeBlank(verse, refname);
            }
            else if (selection == 2) 
            {
                keepLooping = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please provide a valid choice");
            }

        }
    }
}