using System;

namespace Task_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a >> b);
            Console.WriteLine(a << b);
        }
    }
}