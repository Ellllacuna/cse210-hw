using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Bicycles bike = new Bicycles("03 Nov 2022", 3, 30, 6);
        activities.Add(bike);

        Running run = new Running("03 Nov 2022", 4.8, 30);
        activities.Add(run);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}