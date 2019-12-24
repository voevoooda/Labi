using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork2
{
    public class Rectangle : Figure, IPrint
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string FigureName => $"Прямоугольник";

        public Rectangle(double width = 0, double height = 0)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => $"{this.FigureName} с площадью {this.Area()}";

    }
}
