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

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            int listNumber = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{listNumber}. [ ] {goal.GetName()} ({goal.GetDesc()})");
        }
        Console.WriteLine();
    }
}