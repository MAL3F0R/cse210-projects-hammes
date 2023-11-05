using System;

internal class Listing : Activity
{ 
    public Listing(string introMessage, string outroMessage, int duration) : base(introMessage, outroMessage, duration)
    {}

    internal Dictionary<int, string> listDictionary = new Dictionary<int, string>
        {
            {1, "\nWho are people that you appreciate?"},
            {2, "\nWhat are personal strengths of yours?"},
            {3, "\nWho are people that you have helped this week?"},
            {4, "\nWhen have you felt the Holy Ghost this month?"},
            {5, "\nWho are some of your personal heroes?"}
        };

}