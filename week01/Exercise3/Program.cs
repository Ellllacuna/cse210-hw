using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);

            string correct = "no";
            int counter = 0;

            do{
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    correct = "yes";
                    counter += 1;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    correct = "no";
                    counter += 1;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    correct = "no";
                    counter += 1;
                }
            } while (correct != "yes");

            Console.WriteLine($"Guesses: {counter}");

            Console.Write("Do you want to play again? (yes/no) ");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}