using System;

public class Bicycles : Activity
{

    public Bicycles(string date, double distance, int duration) : base(date, distance, duration)
    {
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Stationary Bicycles ({GetDuration()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}