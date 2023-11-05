using System;

internal class Activity
{
    internal string introMessage;
    internal int duration;
    internal string outroMessage;

    public Activity(string message, string messageTwo, int time)
    {
        introMessage = message;
        outroMessage = messageTwo; 
        duration = time;
    }

    internal void DispayIntroMessage()
    {
        Console.WriteLine(introMessage);
    }

    public void DisplayOutroMessage()
    {
        Console.WriteLine(outroMessage);
    }

    internal int GetDuration()
    {
        return(duration);
    }
}