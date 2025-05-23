using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {

    }

    public void Run()
    {
        Console.Clear(); ;

        BreathingActivity breathing = new BreathingActivity();

        breathing.SetName("Breathing Activity");
        breathing.SetDescription("This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathing.DisplayStartingMessage();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        int durationBreathing = int.Parse(durationInput);
        breathing.SetDuration(durationBreathing);

        Console.Clear();

        Console.WriteLine("Getting Ready...");
        breathing.ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationBreathing);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreath in...");
            breathing.ShowCountDown(5);

            Console.Write("\nNow Breath out...");
            breathing.ShowCountDown(5);
        }

        breathing.DisplayEndingMessage();
        breathing.ShowSpinner(5);
    }
}