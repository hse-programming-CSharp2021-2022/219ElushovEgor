using System;

namespace Task_4
{
    class Program
    {
        public static int F(int a)
        {
            return a % 10 * 1000 + ((a / 10) % 10) * 100 + ((a / 100) % 10) * 10 + ((a / 1000) % 10);
        }
        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && (n > 999) && (n < 10000))
            {
                Console.WriteLine(F(n));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
