using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            var rnd = new Random();
            using (var writer =
                   new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; ++i)
                    writer.Write(rnd.Next(1, 101));
            }

            var arr = new int[10];
            using (var reader
                   = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; ++i)
                {
                    arr[i] = reader.ReadInt32();
                    Console.WriteLine(arr[i]);
                }
                int.TryParse(Console.ReadLine(), out int n);
                var min = 1000;
                var ind = 0;
                for (var i = 0; i < 10; ++i)
                {
                    if (Math.Abs(n - arr[i]) < min)
                    {
                        min = Math.Abs(n - arr[i]);
                        ind = i;
                    }
                }
                arr[ind] = n;
            }

            using (var writer
                   = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; ++i)
                    writer.Write(arr[i]);
            }
            using (var reader
                   = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; ++i)
                {
                    arr[i] = reader.ReadInt32();
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}