using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bike = new Bicycles("03 Nov 2022", 3, 30, 6);
        Console.WriteLine(bike.GetSummary());

        Running run = new Running("03 Nov 2022", 4.8, 30, 9.7);
        Console.WriteLine(run.GetSummary);
    }
}