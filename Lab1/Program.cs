using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Гоголь Илья ИУ5-31Б";
            double A, B, C;
            string a, b, c;
            string answ = "yes";
            while (answ == "yes")
            {
                if ((args != null) && (args.Length>=1))
                {
                    a = args[0];
                }
                else
                {
                    Console.Write("A = ");
                    a = Console.ReadLine();
                }
                while (!double.TryParse(a, out A))
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    a = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 2)) {
                    b = args[1];
                }
                else
                {
                    Console.Write("B = ");
                    b = Console.ReadLine();
                }
                while (!double.TryParse(b, out B))
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    b = Console.ReadLine();
                }
                if ((args != null) && (args.Length >= 3)) {
                    c = args[2];
                }
                else
                {
                    Console.Write("C = ");
                    c = Console.ReadLine();
                }
                while (!double.TryParse(c, out C))
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    c = Console.ReadLine();
                }


                if ((A == 0) && (B == 0) && (C == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень уравнения - любое число.");
                    Console.WriteLine("Повторим? yes/no");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((C != 0) && (B == 0) && (A == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет решений.");
                    Console.WriteLine("Повторим? yes/no");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((B != 0) && (A == 0))
                {
                    double X = -C / B;
                    if (X < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет действительных корней.");
                        Console.WriteLine("Повторим? yes/no");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (X == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:\n0");
                        Console.WriteLine("Повторим? yes/no");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни уравнения:\n{Math.Sqrt(X)}\n{-Math.Sqrt(X)}");
                        Console.WriteLine("Повторим? yes/no");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    double D = B * B - 4 * A * C;
                    if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Дискрименант меньше нуля. Уравнение не имеет действительных корней.");
                        Console.WriteLine("Повторим? yes/no");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        double X = ((-1 * B) - Math.Sqrt(D)) / (2 * A);
                        double Y = ((-1 * B) + Math.Sqrt(D)) / (2 * A);
                        if ((X < 0) && (Y < 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Уравнение не имеет действительных корней.");
                            Console.WriteLine("Повторим? yes/no");
                            answ = Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения:");
                            if (X > 0)
                            {
                                double X_1 = Math.Sqrt(X);
                                double X_2 = -1 * X_1;
                                Console.WriteLine($"{X_1} {X_2}");
                            }
                            else if (X == 0)
                                Console.WriteLine(X);
                            if ((Y > 0) && (X != Y))
                            {
                                double Y_1 = Math.Sqrt(Y);
                                double Y_2 = -1 * Y_1;
                                Console.WriteLine($"{Y_1} {Y_2}");
                            }
                            else if ((Y == 0) && (X != Y))
                                Console.WriteLine(Y);
                            Console.WriteLine("Повторим? yes/no");
                            answ = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                args = null;
                }
            }
            
        }
    }

