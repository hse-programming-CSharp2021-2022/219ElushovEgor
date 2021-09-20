using System;

namespace task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            do
            {
                Console.WriteLine("Введите a: ");
            } while (!double.TryParse(Console.ReadLine(), out a));
            
            do
            {
                Console.WriteLine("Введите b: ");
            } while (!double.TryParse(Console.ReadLine(), out b));

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Некорректные данные");
                return;
            }
            
            Console.WriteLine("Длина гипотенузы равна: " + Math.Sqrt(a * a + b * b));
        }
    }
}