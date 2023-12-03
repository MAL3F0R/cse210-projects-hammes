using System;

internal class Comment
{
    internal void DisplayComment(string author, string commentText)
    {
        Console.WriteLine($"Comment: {commentText}, Author: {author}");
    }
}