using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        public delegate double T(double n);
        class ConvertT
        {
            public double FC(double temp)
            {
                return (double)5 / 9 * (temp - 32);
            }
            public double CF(double temp)
            {
                return (double)9 / 5 * temp + 32;
            }
        }

        class StaticTempConverters
        {
            public static double CK(double temp)
            { return temp + 273.15; }
            public static double KC(double temp)
            { return temp - 273.15; }
            public static double CR(double temp) => (temp + 273.15) * (double)9 / 5;
            public static double RC(double temp) => (temp - 491.67) * (double)5 / 9;
            public static double CRe(double temp) => temp * (double)4 / 5;
            public static double ReC(double temp) => temp * (double)5 / 4;

        }
        static void Main(string[] args)
        {
            T D1 = new ConvertT().CF;
            T D2 = new ConvertT().FC;
            Console.WriteLine(D1(145.63));
            Console.WriteLine(D2(24.45));
            ConvertT tempConverter = new ConvertT();
            T temp1 = new T(tempConverter.FC);
            T temp2 = new T(tempConverter.CF);
            T[] arrConverters = { temp1 };
            T temp3 = new T(StaticTempConverters.CK);
            T temp4 = new T(StaticTempConverters.CR);
            T temp5 = new T(StaticTempConverters.CRe);
            arrConverters = new T[] { temp2, temp3, temp4, temp5 };
            Console.Write("Введите температуру в Цельсиях(С°): ");
            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp)) Console.Write("Необходимо ввести целое число, температуру в Цельсиях(С°):");
            foreach (var del in arrConverters)
                Console.WriteLine(del.Method.Name + " : " + del(temp) + "°");
        }
    }
}