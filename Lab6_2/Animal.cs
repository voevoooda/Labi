using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    class Animal
    {
        public Animal()
        {
            Name = "Бобик";
            Size = 4;
        }
        public Animal(int size)
        {
            Name = "Бобик";
            Size = size;
        }
        public Animal(string name)
        {
            Name = name;
            Size = 4;
        }

        [AttributeClass("Это просто размер")]
        public int Size { get; private set; } // в условных единицах
        [AttributeClass(Description = "А это имя")]
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Keep moving");
        }

    }
}
