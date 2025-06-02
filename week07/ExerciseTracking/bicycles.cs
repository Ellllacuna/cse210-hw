using System;

public class Bicycles : Activity
{
    private int _speed;

    public Bicycles(string date, double distance, int duration, int speed) : base(date, distance, duration)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Stationary Bicycles ({_duration} min)- Distance {_distance} miles, Speed {_speed} mph, Pace: {GetPace()} min per mile";
    }
}