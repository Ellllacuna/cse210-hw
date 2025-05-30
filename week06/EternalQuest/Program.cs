using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool Quit = false;

        List<Goal> goals = new List<Goal>();

        do
        {
            Console.WriteLine("You have 0 points\n\n");
            Console.WriteLine("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //for create new goal
                Console.Write("The Types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of Goal would you like to create? ");
                string goalTypeInput = Console.ReadLine();

                if (goalTypeInput == "1")
                {
                    //for simple goal
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string descriptionText = Console.ReadLine();

                    Console.Write("What is the amount of points assiciated with this goal? ");
                    string pointsText = Console.ReadLine();
                    Console.WriteLine("");

                    SimpleGoal simplegoal = new SimpleGoal(goalName, descriptionText, pointsText);
                    goals.Add(simplegoal);
                }
                else if (goalTypeInput == "2")
                {
                    //for eternal goal
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string descriptionText = Console.ReadLine();

                    Console.Write("What is the amount of points assiciated with this goal? ");
                    string pointsText = Console.ReadLine();
                    Console.WriteLine("");

                    EternalGoal eternalGoal = new EternalGoal(goalName, descriptionText, pointsText);
                    goals.Add(eternalGoal);
                }
            }
            else if (userInput == "2")
            {
                //for list goals
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goals)
                {
                    int listNumber = goals.IndexOf(goal) + 1;
                    Console.WriteLine($"{listNumber}. [ ] {goal.GetName()} ({goal.GetDesc()})");
                }
                Console.WriteLine();
            }
        } while (!Quit);
    }
}