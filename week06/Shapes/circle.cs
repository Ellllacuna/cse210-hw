using System;
using System.Runtime.CompilerServices;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 3.14 * (_radius * _radius);
        Console.WriteLine(area);
        return area;
    }
}