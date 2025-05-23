using System;

public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectingActivity() : base()
    {

    }

    public void Run()
    {
        Console.Clear();

        ReflectingActivity reflecting = new ReflectingActivity();
        reflecting.SetName("Refecting Activity");
        reflecting.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflecting.DisplayStartingMessage();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        int durationReflecting = int.Parse(durationInput);

        Console.Clear();

        //beginning of get ready screen
        Console.WriteLine("\n\nGet ready...");
        reflecting.ShowSpinner(5);
        Console.WriteLine("\n");

        Console.WriteLine("Consider the following prompt:\n");
        reflecting.DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.\n");
        Console.ReadLine();

        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        reflecting.ShowCountDown(5);
        //end of get ready screen

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationReflecting);

        //original
        // while (DateTime.Now < endTime)
        // {
        //     reflecting.DisplayQuestions();
        //     reflecting.ShowSpinner(10);
        //     Console.WriteLine();
        // }

        // extra

        List<string> shuffledQuestions = GetShuffledQuestions(_questions);
        while (DateTime.Now < endTime)
        {
            foreach (string question in shuffledQuestions)
            {
                Console.Write($"> {question}");
                reflecting.ShowSpinner(5);
                Console.WriteLine();
            }
        }


    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---\n");
    }

    // public string GetRandomQuestion()
    // {
    //     Random rand = new Random();
    //     int i = rand.Next(_questions.Count);
    //     string randomQuestion = _questions[i];
    //     return randomQuestion;
    // }


    //extra: making sure the user never gets the same question twice
    //using the fisher-yates shuffle algorithm to shuffle the list and 
    //cycle through it, making sure that it never repeats.
    private List<string> GetShuffledQuestions(List<string> list)
    {
        Random rand = new Random();
        List<string> shuffledList = new List<string>(list);

        int n = shuffledList.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);

            string temp = shuffledList[i];
            shuffledList[i] = shuffledList[j];
            shuffledList[j] = temp;
        }

        return shuffledList;
    }

    // public void DisplayQuestions()
    // {
    //     string question = GetRandomQuestion();
    //     Console.Write($">{question}  ");
    // }
    
}