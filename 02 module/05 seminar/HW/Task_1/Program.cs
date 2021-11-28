using System;
using Task04Lib_Shape;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int n1 = random.Next(3, 5), n2 = random.Next(3, 5), n3 = random.Next(3, 5);
            var arr = new Shape[n1 + n2 + n3];
            for(var i = 0; i < n1; i++)
            {
                arr[i] = new Circle(random.Next(1, 10));
            }
            for (var i = n1; i < n2 + n1; i++)
            {
                arr[i] = new Cylinder(random.Next(1, 10), random.Next(1, 10));
            }

            for (var i = n2 + n1; i < n1 + n2 + n3; i++)
            {
                arr[i] = new Sphere(random.Next(1, 10));
            }
            foreach (var i in arr)
            {
                if (i is Sphere)
                    Console.Write("Sphere: ");
                else if (i is Circle)
                    Console.Write("Circle: ");
                else
                    Console.Write("Cylinder: ");
                Console.WriteLine(i.Area());
            }
        }
    }
}
