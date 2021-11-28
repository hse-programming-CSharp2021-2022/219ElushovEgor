using System;
using System.IO;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 1;
                Console.WriteLine(b / a);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            /* Не понимаю почему не работает
            try
            {
                string a = null;
                Console.WriteLine(a.Split());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            try
            {
                int[] a = new int[1];
                Console.WriteLine(a[1]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                File.ReadAllLines("AHAHAH");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                File.ReadAllLines("C:/AHAHAH/a.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var a = new List<int>();
                Console.WriteLine(a[-1]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var a = "a";
                int.Parse(a);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int value = 900000000;
                int square = value * value;
                Console.WriteLine("{0} ^ 2 = {1}", value, square);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                File.ReadAllLines("K:/a.txt");
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                object t = "AHAHAH";
                int x = (int)t;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
