using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, 0.0, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_duration} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}