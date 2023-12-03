using System;
using System.IO.Pipes;

internal class Video
{ 
    internal void DisplayVideo(string videoTitle, string author, double length)
    {
        Console.WriteLine($"Video: {videoTitle}, Author: {author}, Length: {length} seconds.");
    }

}