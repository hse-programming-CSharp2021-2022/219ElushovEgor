using System;

namespace Task_2
{
    class Program
    {
        public static double F(double x, double y)
        {
            if (x < y && x > 0)
                return x + Math.Sin(y);
            else if (x > y && x < 0)
                return y - Math.Cos(x);
            else
                return 0.5 * x * y;
        }
        static void Main(string[] args)
        {
            double x, y;
            if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(F(x, y));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
