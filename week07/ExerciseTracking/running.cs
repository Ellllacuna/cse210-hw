using System;

public class Running : Activity
{

    public Running(string date, double distance, int duration) : base(date, distance, duration)
    {

    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}