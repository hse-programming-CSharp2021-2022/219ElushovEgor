using System;

namespace Task_1
{
    interface IFigure
    { double Area { get; } }

    class Square : IFigure
    {
        double Side { get; set; }

        public double Area => Side * Side;

        public Square(double side)
        { Side = side; }
    }

    class Circle : IFigure
    {
        double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public Circle(double r)
        { Radius = r; }
    }

    class Program
    {
        public static void Info<T>(T[] figures, double min) where T : IFigure
        {
            foreach (var figure in figures)
            {
                if (figure.Area > min)
                    Console.WriteLine($"Type: {figure.GetType()}\tArea:{figure.Area}");
            }
        }

        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[10];
            Circle[] circles = new Circle[10];
            Square[] squares = new Square[10];
            Random rnd = new();
            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(2) == 1)
                    figures[i] = new Circle(rnd.Next(11));
                else figures[i] = new Square(rnd.Next(11));
                squares[i] = new Square(rnd.Next(11));
                circles[i] = new Circle(rnd.Next(11));
            }

            Info(figures, 5);
            Console.WriteLine("***");
            Info(circles, 5);
            Console.WriteLine("***");
            Info(squares, 5);
        }
    }
}