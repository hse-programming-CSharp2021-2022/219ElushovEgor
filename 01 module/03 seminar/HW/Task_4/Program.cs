using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            if (!int.TryParse(Console.ReadLine(), out a) && a < 100 && a > 999)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out b) && b < 100 && b > 999)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out c) && c < 100 && c > 999)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (a % 100 < b % 100 && a % 100 < c)
                Console.WriteLine(a);
            else if (b % 100 < a % 100 && b % 100 < c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }
    }
}
