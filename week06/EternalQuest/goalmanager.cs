using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        bool Quit = false;
        do
        {
            Console.WriteLine("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
        } while (!Quit);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            int listNumber = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{listNumber}. [ ] {goal.GetDetailString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.Write("The Types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of Goal would you like to create? ");
        string goalTypeInput = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string descriptionText = Console.ReadLine();

        Console.Write("What is the amount of points assiciated with this goal? ");
        string pointsText = Console.ReadLine();
        Console.WriteLine("");

        if (goalTypeInput == "1")
        {
            SimpleGoal simplegoal = new SimpleGoal(goalName, descriptionText, pointsText);
            _goals.Add(simplegoal);
        }
        else if (goalTypeInput == "2")
        {
            EternalGoal eternalgoal = new EternalGoal(goalName, descriptionText, pointsText);
            _goals.Add(eternalgoal);
        }

    }
}