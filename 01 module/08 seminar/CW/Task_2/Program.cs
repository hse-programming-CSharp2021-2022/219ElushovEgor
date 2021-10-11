using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            int[][] a = new int[n][];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                a[i] = new int[r.Next(5, 16)];
            for(int i = 0; i < n; i++)
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = r.Next(-10, 11);
            foreach (var el in a)
            {
                foreach (var VARIABLE in el)
                {
                    Console.Write(VARIABLE + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Array.Sort(a, (ints, ints1) =>
            {
                if (ints.Length < ints1.Length)
                    return 1;
                else if (ints.Length > ints1.Length)
                    return -1;
                return 0;
            });
            foreach (var el in a)
            {
                foreach (var VARIABLE in el)
                {
                    Console.Write(VARIABLE + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}