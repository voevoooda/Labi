using System;

namespace LaboratoryWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(10);
            var circle = new Circle(20);
            var rectangle = new Rectangle(5, 4);
            Console.WriteLine($"{circle.ToString()}, {rectangle.ToString()}, {square.ToString()}");
        }
    }
}
