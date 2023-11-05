using System;

internal class Breathing : Activity
{
    private int breathinTime;
    private int breathoutTime;

    public Breathing(string introMessage, string outroMessage, int duration) : base(introMessage, outroMessage, duration)
    {
        breathinTime = duration;
        breathoutTime = duration / 2;
    }

    internal void TimingBar(int progress, int max)
    {
        Console.CursorLeft = 0;
        Console.Write("[");

        int barWidth = (int)((double)progress / max * 100);
        for (int i = 0; i < max; i++)
        {
            if (i < barWidth)
                Console.Write("=");
            else
                Console.Write(" ");
        }

        Console.Write("] " + barWidth + "%");
    }
}
