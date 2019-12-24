using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork2
{
    public abstract class Figure : IComparable
    {

        public abstract string FigureName { get; }

        public abstract double Area();

        public int CompareTo(object obj)
        {
            var figure = (Figure)obj;
            if (this.Area() < figure.Area()) return -1;
            if (this.Area() == figure.Area()) return 0;
            return 1;
        }

    }
}
