using System;

class Program
{
    static void Main(string[] args)
    {
        Bicycles bike = new Bicycles("03 Nov 2022", 3, 30, 6);
        Console.WriteLine(bike.GetSummary());
    }
}