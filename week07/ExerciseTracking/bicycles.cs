using System;

public class Bicycles : Activity
{

    public Bicycles(string date, double distance, int duration) : base(date, distance, duration)
    {
    }

    public override string GetSummary()
    {
        return $"{_date} Stationary Bicycles ({_duration} min)- Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}