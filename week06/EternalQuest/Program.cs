using System;

class Program
{
    static void Main(string[] args)
    {
        bool Quit = false;

        do
        {
            Console.WriteLine("You have 0 points\n\n");
            //update this with the actual points variable
            Console.WriteLine("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            
        } while (!Quit);
    }
}