using System;

class Program
{
    static void Main(string[] args)
    {       
        Fraction f1 = new Fraction( 1,  3);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
    }
}