using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void GenArray(out int[] array, int n)
        {
            array = new int[n];
            var random = new Random();
            for (var i = 0; i < n; i++)
                array[i] = random.Next(1, 10001);
        }

        static bool f1(int a)
        {
            return a % 3 == 0 && a > 9 && a < 100;
        }

        static bool f2(int a)
        {
            string s = a.ToString();
            for (var i = 0; i < a.ToString().Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array;
            GenArray(out array, n);
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
            var select1 = from a in array
                          where f1(a)
                          select a;
            foreach (var i in select1)
                Console.Write(i + " ");
            Console.WriteLine();

            var select2 = from a in array
                          orderby a
                          where f2(a)
                          select a;

            foreach (var i in select2)
                Console.Write(i + " ");
            Console.WriteLine();

            var select3 = from a in array
                          orderby f3(a);
        }
    }
}
