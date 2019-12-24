using System;

namespace Lab6_1
{
    class Program
    {
        delegate int Operation(int lhs, int rhs);
        static int Multiplication(int lhs, int rhs) => lhs * rhs;
        static int Division(int lhs, int rhs)
        {
            try
            {
                return lhs / rhs;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль");
                return 0;
            }
        }
        static void Manager(int lhs, int rhs, Operation operation) 
            => Console.WriteLine(operation(lhs, rhs));

        static void ManagerF(int lhs, int rhs, Func<int, int, int> operation)
            => Console.WriteLine(operation(lhs, rhs));
        static void Main(string[] args)
        {
            Operation op = new Operation(Multiplication);
            Manager(3, 4, op);
            op = Division;
            Manager(3, 4, op);
            ManagerF(3, 4, Division);
            ManagerF(3, 4, (lhs, rhs) => lhs * rhs);
        }
    }
}
