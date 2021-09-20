using System;

namespace Task_2
{
    class Program
    {
        public static int F(int n)
        {
            int first = n % 10, second = (n / 10) % 10, third = (n / 100) % 10;
            int max = 0;
            if (first > second && first > third)
            {
                max = first * 100 + Math.Max(second, third) * 10 + Math.Min(second, third);
            }
            else if (second > first && second > third)
            {
                max = second * 100 + Math.Max(first, third) * 10 + Math.Min(first, third);
            }
            else
                max = third * 100 + Math.Max(first, second) * 10 + Math.Min(first, second);
            return max;
        }
        static void Main(string[] args)
        {
            int n;
            bool f = int.TryParse(Console.ReadLine(), out n);

            if (f && n > 99 && n < 1000)
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
