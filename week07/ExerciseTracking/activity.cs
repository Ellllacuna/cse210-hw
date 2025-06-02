using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    protected int _distance;
    protected string _date;
    protected int _speed;
    protected int _duration;

    public Activity(string date, int distance, int speed, int duration)
    {
        _distance = distance;
        _date = date;
        _speed = speed;
        _duration = duration;
    }

    public virtual int GetDistance()
    {
        return _distance;
    }

    public int GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public int GetPace()
    {
        return _duration / _distance;
    }

    public abstract string GetSummary();
}