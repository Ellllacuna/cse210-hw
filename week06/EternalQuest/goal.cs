using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDesc()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "string";
    }
    public abstract string GetStringRepresentation();
}