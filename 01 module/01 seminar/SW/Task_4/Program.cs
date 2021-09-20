using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string result = "5 / 3 = " + 5 / 3;
            Console.WriteLine(result);
            result = "5.0 / 3.0 = " + 5.0 / 3.0;
            Console.WriteLine(result);
            result = 5 / 3 + " - Это 5/3";
            Console.WriteLine(result);
        }
    }
}