using System;

namespace Task_6
{
    class Program
    {
        public static void F(double n, int x)
        {
            double c = n * ((double)x / 100);
            Console.WriteLine("{0:C2}", c);
        }
        static void Main(string[] args)
        {
            double n;
            if (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int x;
            if (int.TryParse(Console.ReadLine(), out x) && x >= 0 && x <= 100)
                F(n, x);
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
