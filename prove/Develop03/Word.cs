using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public static class Word
{
    static Random random = new Random();
    public static void exitProgram(string userInput)
    {
        if (userInput == "quit")
        {
            Environment.Exit(0);
        }
    }
    
    public static void MakeBlank(string inputString, string inputRef)
    {
        Console.WriteLine("Hit any key to hide more words, or type 'quit' to exit: ");
        string inputType = Console.ReadLine();
        exitProgram(inputType);
        Console.Clear();

        

        int loopCount = 0;

        string[] words = inputString.Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            Console.WriteLine("No string passed to blank out");
        }

        StringBuilder output = new StringBuilder(inputString);
        List<int> blankedPositions = new List<int>();

        while (output.ToString().Contains(" "))
        {
            int index = GetRandomBlankPosition(words.Length, blankedPositions);
            if (index == -1)
            {
                break;
            }

            loopCount += 1;
            string word = words[index];
            string blankedWord = new string('_', word.Length);

            output = output.Replace(word, blankedWord);

            words = output.ToString().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            blankedPositions.Add(index);
            
            Console.WriteLine($"{inputRef}, {output.ToString()}");
            Console.WriteLine("Hit any key to hide more words, or type 'quit' to exit: ");
            string secondInput = Console.ReadLine();
            exitProgram(secondInput);
            Console.Clear();
        }

        static int GetRandomBlankPosition(int wordCount, List<int> blankedPositions)
        {
                if (blankedPositions.Count == wordCount)
                {
                    // All words have been blanked
                    return -1;
                }

                int index;
                do
                {
                    index = random.Next(wordCount);
                } while (blankedPositions.Contains(index));

                return index;
        }
    }
}