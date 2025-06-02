using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Bicycles bike = new Bicycles("02 Jun 2025", 3, 75);
        activities.Add(bike);

        Running run = new Running("09 Apr 2002", 4.8, 30);
        activities.Add(run);

        Swimming swim = new Swimming("03 Nov 2022", 30, 50);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"-{activity.GetSummary()}\n");
        }
    }
}