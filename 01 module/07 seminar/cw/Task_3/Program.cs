using System;

namespace Task_3
{
    internal class Program
    {
        public static void Print(int[] a)
        {
            foreach (var el in a)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] a = new int[100];
            Random r = new Random();
            for (int i = 0; i < 100; i++)
                a[i] = i + 1;
            for(int i = 0; i < 100; i++)
            {
                int i1 = r.Next(0, 100), i2 = r.Next(0, 100);
                (a[i2], a[i1]) = (a[i1], a[i2]);
            }
            Print(a);
            Array.Resize(ref a, 99);
            int sum = 0;
            for (int i = 0; i < 99; i++)
                sum += a[i];
            Console.WriteLine(5050 - sum);
        }
    }
}