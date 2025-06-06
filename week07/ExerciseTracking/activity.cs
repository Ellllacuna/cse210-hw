using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    private double _distance;
    private string _date;
    private int _duration;

    public Activity(string date, double distance,int duration)
    {
        _distance = distance;
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public virtual double GetPace()
    {
        return _duration / _distance;
    }

    public abstract string GetSummary();
}