using System;

namespace Task_1
{
    class Program
    {
        public static bool F (double x, double y)
        {
            if (x * x + y * y <= 4 && x >= 0  && y - x <= 0)
                return true;
            else 
                return false;
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
