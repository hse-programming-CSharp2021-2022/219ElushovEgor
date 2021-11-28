using System;

namespace Task_1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        private double Ro
        {
            get => X * X + Y * Y;
        }

        private double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                if (X == 0 && Y > 0)
                    return Math.PI / 2;
                if (X == 0 && Y < 0)
                    return 3 * Math.PI / 2;
                if (X == 0 && Y == 0)
                    return 0;
                return -1;
            }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point() : this(0, 0)
        {
        }

        public override string ToString()
        {
            return $"X = {X:F2}, Y = {Y:F2}, Ro = {Ro:F2}, Fi = {Fi:F2}";
        }

        public static int Compare(Point a, Point b)
        {
            if (a.Ro < b.Ro)
                return -1;
            if (Math.Abs(a.Ro - b.Ro) < Double.Epsilon)
                return 0;
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a);
            b = new Point(0, 3);
            Console.WriteLine(b);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                var arr = new []{ a, b, c };
                Array.Sort(arr, Point.Compare);
                foreach (var i in arr)
                {
                    Console.WriteLine(i);
                }
            } while (x != 0 | y != 0);

        }
    }
}
