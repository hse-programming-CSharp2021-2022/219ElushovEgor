using System;

namespace Task1
{
    class MyComplex
    {
        public double re, im;

        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }

        public static MyComplex operator --(MyComplex mc) => new (mc.re - 1, mc.im - 1);

        public static MyComplex operator +(MyComplex firstComplex, MyComplex secondComplex) =>
            new (firstComplex.re + secondComplex.re, firstComplex.im + secondComplex.im);

        public static MyComplex operator -(MyComplex firstComplex, MyComplex secondComplex) =>
            new (firstComplex.re - secondComplex.re, firstComplex.im - secondComplex.im);

        public static MyComplex operator *(MyComplex firstComplex, MyComplex secondComplex) =>
            new (firstComplex.re * secondComplex.re - firstComplex.im * secondComplex.im,
                firstComplex.re * secondComplex.im + firstComplex.im * secondComplex.re);

        public static MyComplex operator /(MyComplex firstComplex, MyComplex secondComplex) =>
            new ((firstComplex.re * secondComplex.re + firstComplex.im * secondComplex.im) / 
                 (secondComplex.re * secondComplex.re + secondComplex.im * secondComplex.im),
                (firstComplex.im * secondComplex.re - firstComplex.re * secondComplex.im)/
                (secondComplex.re * secondComplex.re + secondComplex.im * secondComplex.im));

        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }

        public static bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }

        public static bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public override string ToString()
        {
            return $"real={re}, image={im}";
        }
    }

    class Program
    {
        static void Display(MyComplex cs)
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MyComplex c1 = new MyComplex(4, 3.3);
            MyComplex c2 = new MyComplex(2, 8.3);
            Console.WriteLine($"a + b = {c1 + c2}");
            Console.WriteLine($"a - b = {c1 - c2}");
            Console.WriteLine($"a * b = {c1 * c2}");
            Console.WriteLine($"a + b = {c1 / c2}");
        }
    }
}
