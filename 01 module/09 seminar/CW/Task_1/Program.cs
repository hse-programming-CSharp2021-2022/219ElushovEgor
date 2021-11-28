using System;

namespace Task_1
{
    internal class Program
    {
        public static int count(int a)
        {
            int count = 0;
            while (a != 0)
            {
                count++;
                a /= 10;
            }

            return count;
        }
        
        public static int sum(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }

            return sum;
        }
        
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                a[i] = r.Next(0, 1001);
            Array.Sort(a, (i, i1) =>
            {
                if (count(i) > count(i1))
                    return -1;
                return 1;
            });
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(a, (i, i1) =>
            {
                if (i % 2 == 0 && i1 % 2 != 0)
                    return 1;
                return -1;
            });
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(a, (i, i1) =>
            {
                if (sum(i) < sum(i1))
                    return -1;
                return 1;
            });
            Array.ForEach(a, el => Console.Write(el + " "));
            Console.WriteLine();
        }
    }
}