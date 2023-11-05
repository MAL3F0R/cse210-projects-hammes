using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


class Program
{
    internal static void ExitOption()
    {
        Console.Clear();
        Environment.Exit(0);
    }
    private static void Main()
    {
        bool keepLooping = true;
        int userDuration = 0;

        while (keepLooping == true)
        {
            Console.WriteLine(@"Welcome to the mindfulness app. Please select an option from the list:
1. Breathing Activity
2. Reflection Activity
3. Listing Activity
4. Quit
Enter your choice: ");
        int userChoice = Int32.Parse(Console.ReadLine());
        if (userChoice < 4)
        {
            Console.WriteLine("Provide a time in seconds for your activity: ");
            userDuration = Int32.Parse(Console.ReadLine()) * 10;
        }

        switch(userChoice)
        {
           case 1:
            Console.Clear();
            int totalWidth = 55;
                Breathing actOne = new Breathing(@"Welcome to the breathing activty, hold and release your breath in 
    accordance with the prompts", "Returning to menu...", userDuration);
                actOne.DispayIntroMessage();
                Thread.Sleep(5000);
                Console.CursorVisible = false;
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\nTake a breath in...");
                        for (int i = 0; i <= totalWidth; i++)
                    {
                        actOne.TimingBar(i, totalWidth);
                        Thread.Sleep(actOne.duration);
                    }
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine("\nNow release...");
                    for (int i = totalWidth; i >= 0; i--)
                    {
                        actOne.TimingBar(i, totalWidth);
                        Thread.Sleep(actOne.duration);
                    }
                    Console.Clear();
                }
            Console.CursorVisible = true;
            actOne.DisplayOutroMessage();
            Thread.Sleep(2000);
                break;

            case 2:
                Console.Clear();
                Random rndOne = new Random();
                int randomOne = rndOne.Next(1, 4);
                Random rndTwo = new Random();
                int randomTwo = rndOne.Next(1, 9);

                Reflection actTwo = new Reflection(@"Welcome to the Relection acitivity. Think and reflect about the 
following questions as they appear.", "Now returning to menu...", userDuration);
                List<string> prompts = actTwo.RandomPrompt(randomOne, randomTwo);

                actTwo.DispayIntroMessage();
                Thread.Sleep(2000);

                Console.WriteLine(prompts[0]);
                Thread.Sleep(actTwo.duration * 100);
                Console.WriteLine(prompts[1]);
                Thread.Sleep(actTwo.duration * 100);

                actTwo.DisplayOutroMessage();
                Thread.Sleep(2000);
                break;

            case 3:
                Console.Clear();

                Listing actThree = new Listing(@"Welcome to the listing activity. List as 
many things you can in response to each question in the given time", 
                "Going back to menu...", userDuration);

                actThree.DispayIntroMessage();
                Thread.Sleep(2000);

                for (int v = 1; v < 5; v++ )
                    {
                        Console.WriteLine(actThree.listDictionary[v]);
                        Thread.Sleep(actThree.duration * 100);
                    }
                actThree.DisplayOutroMessage();
                Thread.Sleep(2000);
                break;  

            case 4:
                ExitOption();
                break;



        }
        }

    }
        
}