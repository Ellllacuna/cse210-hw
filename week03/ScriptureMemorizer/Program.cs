using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference;
        Scripture scripture;

        Console.WriteLine("1. Preloaded Scripture\n2. Use your own ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            reference = new Reference("Matthew", 10, 16, 16);
            scripture = new Scripture(reference, "I am sending you out like sheep among wolves. Therefore be as shrewd as snakes and as innocent as doves.");
        } else
        {
            Console.Write("Book: ");
            string bookInput = Console.ReadLine();

            Console.Write("Chapter: ");
            string chapterInput = Console.ReadLine();
            int chapter = int.Parse(chapterInput);

            Console.Write("Starting verse: ");
            string startVerseInput = Console.ReadLine();
            int startVerse = int.Parse(startVerseInput);

            Console.Write("End Verse: ");
            string endVerseInput = Console.ReadLine();
            int endVerse = int.Parse(endVerseInput);

            Console.Write("Text: ");
            string textInput = Console.ReadLine();

            reference = new Reference(bookInput, chapter, startVerse, endVerse);
            scripture = new Scripture(reference, textInput);
        }

       while (!scripture.IsCompletelyHidden())
       {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to hide more words, or type 'quit' to quit");

        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            Console.Clear();
            Console.WriteLine("Goodbye");
            return;
        }

        scripture.HideRandomWords(3);
       }

       Console.Clear();
       Console.WriteLine(scripture.GetDisplayText());
       Console.WriteLine("\nAll words hidden. Press Enter to exit.");
       Console.ReadLine();

    }
}