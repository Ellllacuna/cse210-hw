using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congradulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return IsComplete();
    }

    public override string GetStringRepresentation()
    {
        return "string placeholder";
    }
}