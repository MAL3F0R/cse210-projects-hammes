using System;
using System.Diagnostics;

internal class Reflection : Activity
{
    internal int questionTime;

    public Reflection(string introMessage, string outroMessage, int duration) : base(introMessage, outroMessage, duration)
    {
        questionTime = duration;
    }

    public List<string> RandomPrompt(int randomOne, int randomTwo)
    {
        Dictionary<int, string> promptDictionary = new Dictionary<int, string>
        {
            {1, "\nThink of a time when you stood up for someone else."},
            {2, "\nThink of a time when you did something really difficult."},
            {3, "\nThink of a time when you helped someone in need."},
            {4, "\nThink of a time when you did something truly selfless."}
        };

        Dictionary<int, string> followupDictionary = new Dictionary<int, string>
        {
            {1, "\nWhy was this experience meaningful to you?"},
            {2, "\nHave you ever done anything like this before?"},
            {3, "\nHow did you get started?"},
            {4, "\nHow did you feel when it was complete?"},
            {5, "\nWhat made this time different than other times when you were not as successful?"},
            {6, "\nWhat is your favorite thing about this experience?"},
            {7, "\nWhat could you learn from this experience that applies to other situations?"},
            {8, "\nWhat did you learn about yourself through this experience?"},
            {9, "\nHow can you keep this experience in mind in the future?"}
        };

        string randomFollowup = followupDictionary[randomTwo];
        string randomPrompt = promptDictionary[randomOne];

        List<string> randomQuestions= new List<string>();
        randomQuestions.Add(randomPrompt);
        randomQuestions.Add(randomFollowup);
        
        return (randomQuestions);
    }
}  