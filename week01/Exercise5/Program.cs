using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter favorite number: ");
            string favNumberInput = Console.ReadLine();
            int favNumber = int.Parse(favNumberInput);

            return favNumber;
        }

        static int SquareNumber(int x)
        {
            int square = x * x;

            return square;
        }

        static void DisplayResult(int favNumber, string name)
        {
            int square = SquareNumber(favNumber);
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(number, name);
    }
}