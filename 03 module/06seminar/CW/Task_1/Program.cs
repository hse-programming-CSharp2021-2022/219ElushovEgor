using System;

namespace Task_1
{
    class Point
    {
        double x;
        double y;

        public Point(double x0, double y0)
        {
            x = x0;
            y = y0;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Test(Point point)
        {
            return Math.Sqrt((x - point.x) * (x - point.x) + (y - point.x) * (y - point.x));
        }
    }

    class TriangleComp
    {
        private Point p1;
        private Point p2;
        private Point p3;

        private double t1, t2, t3;

        public TriangleComp(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
            t1 = p1.Test(p2);
            t2 = p2.Test(p3);
            t3 = p3.Test(p1);
        }

        public double Square
        {
            get
            {
                var k = (t1 + t2 + t3) / 2;
                return Math.Sqrt((k - t1) * (k - t2) * (k - t3) * k);
            }
        }

        public bool TestPoint(Point point)
        {
            TriangleComp a = new (point.X, point.Y, p1.X, p1.Y, p2.X, p2.Y);
            TriangleComp b = new (point.X, point.Y, p1.X, p1.Y, p3.X, p3.Y);
            TriangleComp c = new (point.X, point.Y, p2.X, p2.Y, p3.X, p3.Y);

            if (a.Square + b.Square + c.Square <= Square)
            {
                Console.Write(Square);
                return true;

            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp p = new(0, 0, 6, 0, 3, 5);
            if (p.TestPoint(new Point(3, 1)))
            {
                Console.Write("Точка принадлежит треугольнику");
            }
            else Console.WriteLine("Точка не принадлежит треугольнику");
        }
    }
}