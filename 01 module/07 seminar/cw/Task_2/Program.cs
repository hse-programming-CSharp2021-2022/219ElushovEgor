using System;

namespace Task_2
{
    internal class Program
    {
        public static void Print(char[] a)
        {
            foreach (var el in a)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] arr = new char[k];
            Random r = new Random();
            for (int i = 0; i < k; i++)
                arr[i] = (char)r.Next('A', 'Z' + 1);
            Print(arr);
            char[] copy = new char[k];
            Array.Copy(arr, copy, k);
            Print(copy);
            
            Array.Sort(copy);
            Print(copy);
            Array.Reverse(copy);
            Print(copy);
        }
    }
}