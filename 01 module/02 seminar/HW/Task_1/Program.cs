using System;

namespace Task_1
{
    class Program
    {
        public static int F(int x)
        {
            return x * (2 + x * ((-3) + x * (9 + x * 12))) - 4;
        }
        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine(F(n));
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
