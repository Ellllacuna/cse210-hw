using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal newEntry = new Journal();
        int userInput = 1;

        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());
            

            if (userInput == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write(">");
                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = prompt;
                entry._entryText = entryText;

                newEntry.AddEntry(entry);
            } else if (userInput == 2)
            {
                newEntry.DisplayAll();
            } else if (userInput == 3)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                newEntry.LoadFromFile(filename);
            } else if (userInput == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                newEntry.SaveToFile(fileName);
            }
        } while (userInput != 5);
    }
}