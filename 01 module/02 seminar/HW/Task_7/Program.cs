using System;

namespace Task_7
{
    class Program
    {
        public static void F1(double a)
        {
            Console.WriteLine((int)a);
            Console.WriteLine(a - (int)a);
        }
        public static void F2(double a)
        {
            Console.WriteLine(a * a);
            Console.WriteLine(Math.Sqrt(a));
        }

        static void Main(string[] args)
        {
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                F1(a);
                if (a >= 0)
                    F2(a);
                else
                    Console.WriteLine("Incorrect input");
            }
            else
                Console.WriteLine("Incorrect input");

        }
    }
}
