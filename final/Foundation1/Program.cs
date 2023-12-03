using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<string> Title = new List<string>();
    static List<string> Author = new List<string>();
    static List<double> Length = new List<double>();
    static List<string> videoOneCommenter = new List<string>();
    static List<string> videoOneCommentText = new List<string>();
    static List<string> videoTwoCommenter = new List<string>();
    static List<string> videoTwoCommentText = new List<string>();
    static List<string> videoThreeCommenter = new List<string>();
    static List<string> videoThreeCommentText = new List<string>();

    static void Main()
    {
        AddVideo("How to change your registry", "CoolVideoGuy", 12.54);
        AddComment(videoOneCommentText, videoOneCommenter, "Nice tutorial!", "User344");
        AddComment(videoOneCommentText, videoOneCommenter, "Good Video.", "InternetDude47");
        AddComment(videoOneCommentText, videoOneCommenter, "Used this to fix my computer. Thnx!", "Mr.Malamute");
        AddVideo("How to say antidisestablishmentarianism backwards ", "DankPoster420", 0.34);
        AddComment(videoTwoCommentText, videoTwoCommenter, "I can't feel my lips now...", "User6835");
        AddComment(videoTwoCommentText, videoTwoCommenter, "What is the square root of a flexnard?", "Bobthevideoguy");
        AddComment(videoTwoCommentText, videoTwoCommenter, "I watching this at 3am", "goatmilker69");
        AddVideo("How to check to engine oil in your car", "Dylancarfixes", 13.45);
        AddComment(videoThreeCommentText, videoThreeCommenter, "Very Helpful!", "Linda Wellington");
        AddComment(videoThreeCommentText, videoThreeCommenter, "Its also a good idea to check the oil color too", "Robert M."); 
        AddComment(videoThreeCommentText, videoThreeCommenter, "Used this to teach my kids", "Bob84");

        Video videoOption = new Video();
        Comment commentChoice = new Comment();
        Console.WriteLine("Video 1:");
        videoOption.DisplayVideo(Title[0], Author[0], Length[0]);
        Console.WriteLine("Video 1 comments: ");
        Console.WriteLine($"Number of Comments: {videoOneCommenter.Count}");
        for (int i = 0; i < 2; i++) 
            {
                commentChoice.DisplayComment(videoOneCommentText[i], videoOneCommenter[i]);
            }
        Console.WriteLine("Video 2:");
        videoOption.DisplayVideo(Title[1], Author[1], Length[1]);
        Console.WriteLine("Video 2 comments: ");
        Console.WriteLine($"Number of Comments: {videoTwoCommenter.Count}");
        for (int j = 0; j < 2; j++) 
            {
                commentChoice.DisplayComment(videoTwoCommentText[j], videoTwoCommenter[j]);
            }
        Console.WriteLine("Video 3:");
        videoOption.DisplayVideo(Title[2], Author[2], Length[2]);
        Console.WriteLine("Video 3 comments: ");
        Console.WriteLine($"Number of Comments: {videoOneCommenter.Count}");
        for (int l = 0; l < 2; l++) 
            {
                commentChoice.DisplayComment(videoThreeCommentText[l], videoThreeCommenter[l]);
            }
        
    }

    static void AddVideo(string videoTitle, string author, double length)
    {
        Title.Add(videoTitle);
        Author.Add(author);
        Length.Add(length);
        
    }

     static void AddComment(List<string> commentList, List<string> authorlist, string commenter, string commentText)
    {
        commentList.Add(commentText);
        authorlist.Add(commenter);
    }
    
    
    
}