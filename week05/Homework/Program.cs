using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriquez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}