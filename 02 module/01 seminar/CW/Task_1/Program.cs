using System;
using System.Text;

namespace Task_1
{

    class Polygon
    {
        private int sideCount;
        private double radius;

        public int SideCount
        {
            set => sideCount = value;
        }

        public double Radius
        {
            set => radius = value;
        }
        public Polygon(int sideCount = 1, double radius = 0)
        {
            this.sideCount = sideCount;
            this.radius = radius;
        }

        private double Perimeter()
        {
            return 2 * radius * Math.Sin(Math.PI / sideCount) * sideCount;
        }

        public double Area()
        {
            return this.Perimeter() * radius / 2;
        }

        public string PolygonData()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Radius: " + radius.ToString() + "\n");
            s.Append("sideCount: " + sideCount.ToString() + "\n");
            s.Append("Perimeter: " + this.Perimeter().ToString() + "\n");
            s.Append("Area: " + this.Area().ToString() + "\n");
            return s.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Polygon[] arr = new Polygon[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество сторон:");
                int sideCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус:");
                double radius = double.Parse(Console.ReadLine());
                arr[i] = new Polygon(sideCount, radius);
            }

            double min = arr[0].Area(), max = arr[0].Area();
            foreach (var i in arr)
            {
                if (i.Area() > max)
                    max = i.Area();
                if (i.Area() < min)
                    min = i.Area();
            }
            Console.WriteLine("Минимальная площадь: " + min);
            Console.WriteLine("Максимальная площадь: " + max);

            foreach (var i in arr)
            {
                Console.WriteLine(i.PolygonData());
            }
        }
    }
}
