using System;

namespace Task_2
{
    internal class Program
    {
        public static void delete(int[] a, int index)
        {
            for (int i = index; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
        }
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                a[i] = r.Next(-10, 11);
            int k = N;
            foreach (var VARIABLE in a)
                Console.Write(VARIABLE + " ");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
                if (a[i] % 2 == 0)
                {
                    delete(a, i);
                    i--;
                    k--;
                }
            for (int i = 0; i < k; i++)
                Console.Write(a[i] + " ");
        }
    }
}