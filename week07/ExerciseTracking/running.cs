using System;

public class Running : Activity
{
    private double _speed;

    public Running(string date, double distance, int duration, double speed) : base(date, distance, duration)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min)- Distance {_distance} miles, Speed {_speed}, Pace: {GetPace()} min per mile";
    }
}