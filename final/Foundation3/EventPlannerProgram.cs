using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Lectures lectures = new Lectures(150, "Creating Financial stability",
        @"This lecture will be given by the local financial stabiltity
group and will feature good finciance techniques.", "4/7/24", "1:00 PM", "701 1st st S WallaWalla WA");
        lectures.DisplayAtendeeLimit(150);
        Receptions receptions = new Receptions("by going to ConnersWedding.com","Connors couple wedding",
        @"Come to the union of the new members of the conners family and celebrate thier special
day.", "8/19/24", "10:00 AM", "5478 3rd Ave W Robertsville Id");
        OutdoorGatherings outdoor = new OutdoorGatherings("Sunny with highs in the mid 70's", 
        "Community Block party at the park", @"Come to the community block party being held at the local park 
this Saturday for Food, Games and Fun.", "7/25/24", "11:00 AM", "Tompson Park 12th st N, Castleton NY.");

    }
}

internal class Event
{
    private string eventTitle;
    private string eventDescription;
    private string eventDate;
    private string eventTime;
    private string eventAddress;
    internal Event(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress)
    {
        Console.WriteLine($"\nEvent Name: {eventTitle} Event Date: {eventDate} Event Time: {eventTime}, Event Address: {eventAddress}");
        Console.WriteLine($"Extended event details: {eventDescription}");
    }
}

internal class Lectures : Event
{
    private int atendeeLimit;
    internal Lectures (int attendees, string eventTitle, string eventDescription, string eventDate,
string eventTime, string eventAddress) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        atendeeLimit = attendees;
    }
    internal void DisplayAtendeeLimit(int attendeeQty)
    {
        Console.WriteLine($"The max number of atendees for this lecture is: {attendeeQty}");
    }
}
internal class Receptions : Event
{
    private string registerAttendance;
    internal Receptions(string register, string eventTitle, string eventDescription, string eventDate,
string eventTime, string eventAddress) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        registerAttendance = register;
    }
    internal void DisplayRsvpInfo(string register)
    {
        Console.WriteLine($"Please RSVP for this event by {register}");
    }
}

internal class OutdoorGatherings : Event
{
    private string weatherOutlook;
    internal OutdoorGatherings (string weather, string eventTitle, string eventDescription, string eventDate,
string eventTime, string eventAddress) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        weatherOutlook = weather;
    }
    internal void DisplayWeather(string weather)
    {
        Console.WriteLine($"The weather outlook for the event is {weather}");
    }
}