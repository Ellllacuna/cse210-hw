using System;
using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = int.Parse(_points);
        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Congratulations! You earned {_points} points and a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";   
    }
}