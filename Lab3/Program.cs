using System;
using System.Collections;
using System.Collections.Generic;
using LaboratoryWork2;

namespace LaboratoryWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(10, 2);
            Square square = new Square(4);

            ArrayList figuresArrayList = new ArrayList
            {
                circle,
                rectangle,
                square
            };
            figuresArrayList.Sort();
            foreach (var figure in figuresArrayList)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.WriteLine();

            var figuresList = new List<Figure>
            {
                circle,
                rectangle,
                square
            };
            figuresList.Sort();
            foreach (var figure in figuresList)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.WriteLine();

            Matrix<Figure> cube = new Matrix<Figure>(3, 3, 3, null);
            cube[0, 0, 0] = rectangle;
            cube[1, 1, 1] = square;
            cube[2, 2, 2] = circle;
            Console.WriteLine(cube.ToString());
            Console.WriteLine();

            SimpleList<Figure> list = new SimpleList<Figure>
            {
                circle
            };
            list.Add(square);
            list.Add(rectangle);
            foreach (var x in list) Console.WriteLine(x.ToString());


            Console.WriteLine("\nСтек");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rectangle);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
        }
    }
}
