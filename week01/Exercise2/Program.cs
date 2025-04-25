using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);

        string letter = "";

        if (gradePercentage >= 90)
        {
            //Console.WriteLine("Grade: A");
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            //Console.WriteLine("Grade: B");
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
           //Console.WriteLine("Grade: C");
           letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            //Console.WriteLine("Grade: C");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("Grade: F");
            letter = "F";
        }

        int lastDigit = gradePercentage % 10;
        string extra = "";
        if (lastDigit >= 7 && !(gradePercentage >= 90))
        {
            extra = "+";
        }
        else if (lastDigit < 3 && !(gradePercentage < 60))
        {
            extra = "-";
        }
        else
        {
            extra = "";
        }

        Console.WriteLine($"Grade: {letter}{extra}");


        if (gradePercentage >= 60)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You Failed");
        }
    }
}
