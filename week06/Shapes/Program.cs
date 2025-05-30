using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 7.0);
        square.GetArea();

        Circle circle = new Circle("Green", 6.9);
        circle.GetArea();

        Rectangle rectangle = new Rectangle("white", 5.0, 6.0);
        rectangle.GetArea();

    }
}