using System;

public class Running : Activity
{

    public Running(string date, double distance, int duration) : base(date, distance, duration)
    {

    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min)- Distance {_distance} miles, Speed {GetSpeed()}, Pace: {GetPace()} min per mile";
    }
}