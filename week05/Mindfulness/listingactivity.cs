using System;
using System.Diagnostics;
using System.Net.Http.Headers;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {

    }

    public void Run()
    {
        Console.Clear(); ;

        ListingActivity listing = new ListingActivity();

        listing.SetName("Listing Activity");
        listing.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listing.DisplayStartingMessage();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        int durationListing = int.Parse(durationInput);
        listing.SetDuration(durationListing);

        Console.Clear();

        Console.WriteLine("\n\nGet ready...");
        listing.ShowSpinner(5);
        Console.WriteLine("\n");

        Console.WriteLine("List as many responses you can to the following prompt:");
        listing.GetRandomPrompt();
        Console.Write("You many begin in: ");
        listing.ShowCountDown(5);
        Console.WriteLine();

        List<string> userResponses = listing.GetListFromUser();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        Console.WriteLine($" --- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());  
        }

        return responses;
    }
}