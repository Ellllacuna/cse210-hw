using System;

class Program
{
    static void Main(string[] args)
    {
        bool Quit = false;

        do
        {
            Console.WriteLine("Menu Options:\n    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }
            else if (userInput == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }
        } while (Quit);
    }
}