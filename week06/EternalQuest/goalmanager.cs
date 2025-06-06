using System;
using System.IO.Compression;

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
            DisplayPlayerInfo();
            Console.WriteLine($"Your current rank is: {GetRank()}\n");

            Console.WriteLine("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Delete a goal\n    7. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
                Console.WriteLine();
            }
            else if (userInput == "2")
            {
                ListGoalDetails();
                Console.WriteLine();
            }
            else if (userInput == "3")
            {
                SaveGoals();
                Console.WriteLine();
            }
            else if (userInput == "4")
            {
                LoadGoals();
                Console.WriteLine();
            }
            else if (userInput == "5")
            {
                RecordEvent();
                Console.WriteLine();
            }
            else if (userInput == "6")
            {
                ListGoalNames();

                Console.Write("What goal do you want to delete? ");
                string deleteInput = Console.ReadLine();

                if (int.TryParse(deleteInput, out int index) && index > 0 && index <= _goals.Count)
                {
                    Console.WriteLine($"Goal '{_goals[index - 1].GetName()}' deleted.");
                    _goals.RemoveAt(index - 1);
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
            else if (userInput == "7")
            {
                Quit = true;
            }
            else
            {
                Console.WriteLine("Please input a valid option");
            }
        } while (!Quit);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            int nameListNumber = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{nameListNumber}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            int listNumber = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{listNumber}. {goal.GetDetailString()}");
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

        string pointsText;
        while (true)
        {
            Console.Write("What is the amount of points assiciated with this goal? ");
            pointsText = Console.ReadLine();

            if (int.TryParse(pointsText, out _))
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a number. Please Try again.");
            }
        }
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
        else if (goalTypeInput == "3")
        {
            int target;
            while (true)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string targetInput = Console.ReadLine();
                if (int.TryParse(targetInput, out target))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a number. Please try again.");
                }
            }

            int bonus;
            while (true)
            {
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusInput = Console.ReadLine();

                if (int.TryParse(bonusInput, out bonus))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a number. Please Try again.");
                }
            }
            ChecklistGoal checklist = new ChecklistGoal(goalName, descriptionText, pointsText, target, bonus);
            _goals.Add(checklist);
        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += int.Parse(_goals[index].GetPoints());
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter File name: ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _score = int.Parse(lines[0]);

            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split(":");
                string[] values = parts[1].Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(values[3]);
                    SimpleGoal simplegoal = new SimpleGoal(values[0], values[1], values[2]);
                    simplegoal.SetComplete(isComplete);
                    _goals.Add(simplegoal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal egoal = new EternalGoal(values[0], values[1], values[2]);
                    _goals.Add(egoal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal cgoal = new ChecklistGoal(values[0], values[1], values[2], int.Parse(values[4]), int.Parse(values[3]));
                    cgoal.SetAmountCompleted(int.Parse(values[5]));
                    _goals.Add(cgoal);
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    public string GetRank()
    {
        int total = _score;

        if (total < 100)
        {
            return "Beginner";
        }
        else if (total >= 100 && total < 200)
        {
            return "Intermediate";
        }
        else if (total >= 200 && total < 300)
        {
            return "Master";
        }
        else
        {
            return "GrandMaster";
        }
    }
}