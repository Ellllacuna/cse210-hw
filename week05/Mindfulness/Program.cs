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

                Console.Clear();
            }
            else if (userInput == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();

                Console.Clear();
            }
            else if (userInput == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();

                Console.Clear();
            }
            else if (userInput == "4")
            {
                Quit = true;
            }
            else
            {
                Console.WriteLine("Please Input a Valid Response");
                Thread.Sleep(5000);
                Console.Clear();
            }
        } while (!Quit);
    }
}