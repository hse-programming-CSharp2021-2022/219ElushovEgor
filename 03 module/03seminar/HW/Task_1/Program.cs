using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var d = new Dot(x, y);
            d.OnCoordChanged += PrintInfo;
            d.DotFlow();
        }

        private static void PrintInfo(Dot dot) => Console.WriteLine($"X: {dot.X} | Y: {dot.Y}");
    }

    public delegate void CoordChanged(Dot dot);

    public class Dot
    {
        public Dot(double x, double y)
        {
            X = x;
            Y = y;
        }

        private Random rnd = new Random();

        public double X { get; set; }
        public double Y { get; set; }

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            for (int i = 0; i < 10; i++)
            {
                var x = rnd.Next(-10, 10) + rnd.NextDouble();
                var y = rnd.Next(-10, 10) + rnd.NextDouble();
                X = x;
                Y = y;
                if (x < 0 && y < 0)
                    OnCoordChanged?.Invoke(this);
            }
        }
    }
}