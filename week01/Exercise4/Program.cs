using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }while (number != 0);

        float sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        int largestNum = -999999999;
        foreach (int i in numbers)
        {
            if (i > largestNum)
            {
                largestNum = i;
            }
        }

        int smallestNum = 99999999;
        foreach (int i in numbers)
        {
            if (i < smallestNum && i > 0)
            smallestNum = i;
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        
        Console.WriteLine("The sorted list is");
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}