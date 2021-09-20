using System;

namespace task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double U, R;
            do
            {
                Console.WriteLine("Введите U: ");
            } while (!double.TryParse(Console.ReadLine(), out U));
            
            do
            {
                Console.WriteLine("Введите R: ");
            } while (!double.TryParse(Console.ReadLine(), out R));

            if (U < 0 || R <= 0)
            {
                Console.WriteLine("Некорректные данные");
                return;
            }
            Console.WriteLine("I = " + U / R);
            Console.WriteLine("P = " + U * U / R);
        }
    }
}