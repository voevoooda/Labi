using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork2
{
    public class Square : Figure, IPrint
    {
        public double Side { get; set; }

        public override string FigureName => $"Квадрат";

        public Square(double side = 0) => Side = side;

        public override double Area() => Side * Side;
        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString() => $"{this.FigureName} с площадью {this.Area()}";

    }
}
