using System;

namespace Task_1
{
    public delegate void SquareSizeChanged(double par);

    class Square
    {
        private (double, double) _topLeft;
        private (double, double) _bottomRight;

        public (double, double) TopLeft
        {
            get => _topLeft;
            set
            {
                _topLeft = value;
                OnSizeChanged?.Invoke(Side);
            }
        }

        public (double, double) BottomRight
        {
            get => _bottomRight;
            set
            {
                _bottomRight = value;
                OnSizeChanged?.Invoke(Side);
            }
        }

        private double Side => TopLeft.Item2 - BottomRight.Item2;

        public event SquareSizeChanged? OnSizeChanged;
    }

    class Program
    {

        static void SquareConsoleInfo(double par) => Console.WriteLine(par.ToString("f2"));

        static void Main()
        {
            double x1, y1, x2, y2;
            (x1, y1, x2, y2) = (0, 0, -10, 10);
            var s = new Square() { BottomRight = (x1, y1), TopLeft = (x2, y2) };
            s.OnSizeChanged += SquareConsoleInfo;
            do
            {
                Console.WriteLine("введите х у:");
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                s.BottomRight = (x, y);
                Console.WriteLine("для окончания нажмите enter");

            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}