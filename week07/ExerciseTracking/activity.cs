using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    protected double _distance;
    protected string _date;
    protected int _duration;

    public Activity(string date, double distance,int duration)
    {
        _distance = distance;
        _date = date;
        _duration = duration;
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