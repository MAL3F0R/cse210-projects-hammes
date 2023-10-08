using System;
using System.Reflection.Metadata;

public class Promptor
{
    public static readonly List<string> PromptsList = new List<string>
    {
        "How was the weather today?", "What is the best part of your day?",
        "Did you talk to anyone new?", "What was the most exciting you look forward to tomarrow?",
        "Did you travel very far today?"
        
    };

    public static string GeneratePrompt()
    {
        Random Num = new Random();
        int GeneratedNum = Num.Next(1, PromptsList.Count) - 1;
        return PromptsList[GeneratedNum];
    }
}