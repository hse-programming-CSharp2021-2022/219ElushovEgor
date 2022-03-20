using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            Random random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] =  random.Next(-1000,1001);
            }
            foreach (var el in array)
            {
                Console.WriteLine(el);
            }
            
            Console.WriteLine();
            var array1 = array.Select(x => x*x).ToArray();
            Array.ForEach(array1, Console.WriteLine);

            Console.WriteLine();
            var array2 = array.Where(x => x > 0 && x < 100).ToArray();
            Array.ForEach(array2, Console.WriteLine);

            Console.WriteLine();
            var array3 = array.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            Array.ForEach(array3, Console.WriteLine);

            Console.WriteLine();
            
            var array4 = array.GroupBy(x => x.ToString().Length).ToArray();
            Array.ForEach(array4, x =>
            {
                Array.ForEach(x.ToArray(), Console.WriteLine);
            });
        }
    }
}