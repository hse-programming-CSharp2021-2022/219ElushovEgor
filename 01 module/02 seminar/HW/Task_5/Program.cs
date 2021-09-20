using System;

namespace Task_5
{
    class Program
    {
        public static bool F(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(F(a, b, c));
        }
    }
}
