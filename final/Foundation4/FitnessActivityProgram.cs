using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        new Running("11/24/23", "Running", 34.0, 3.0);
        new Cycling("12/16/22", "Cycling", 10.0, 8.0);
        new Swimming("5/4/23", "Swimming", 55.0, 3.0, 50.0);
    }
}

internal abstract class FitnessActivity
{
    internal double distance;
    private double time;
    private double speed;
    private double pace;
    private string date;

    internal abstract double CalculateDistance(double distanceIn);

    internal FitnessActivity(string dateCompleted, string activity, 
    double timeElapsed, double distanceElapsed)
    {
        distance = distanceElapsed;
        time = timeElapsed;
        speed = (distanceElapsed / timeElapsed) * 60;
        pace = timeElapsed / distanceElapsed;
        date = dateCompleted;

        Console.WriteLine($@"{date}: {activity} ({time}min) - Distance: {distance}km, 
        Speed: {Math.Round(speed, 2)}kph, Pace: {Math.Round(pace, 2)}min/km");
    }
}

internal class Running : FitnessActivity
{
    internal override double CalculateDistance(double distanceIn)
    {
        distance = distanceIn;
        return distance;
    }

    internal Running(string date, string activity, 
    double timeElapsed, double distanceElapsed) : base(date, activity, 
    timeElapsed, distanceElapsed)
    {

    }
}

internal class Cycling : FitnessActivity
{
    internal override double CalculateDistance(double distanceIn)
    {
        distance = distanceIn;
        return distance;
    }

    internal Cycling(string date, string activity, 
    double timeElapsed, double distanceElapsed) : base(date, activity, 
    timeElapsed, distanceElapsed)
    {

    }

}

internal class Swimming : FitnessActivity
{
    
    internal override double CalculateDistance(double lapsIn)
    {
        distance = (lapsIn * 50) / 1000;
        return distance;
    }

    internal Swimming(string date, string activity, 
    double timeElapsed, double distanceElapsed, double laps) : base(date, activity, 
    timeElapsed, distanceElapsed)
    {

        distance = CalculateDistance(laps);
    }


}