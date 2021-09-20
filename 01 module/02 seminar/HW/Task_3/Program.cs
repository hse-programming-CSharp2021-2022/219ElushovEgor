using System;

namespace Task_3
{
    class Program
    {
        public static string F(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            string answer = "";
            switch(d)
            {
                case > 0:
                    double x1 = (-b + Math.Sqrt(d)) / 2 * a,
                        x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    answer += x1.ToString() + " " + x2.ToString();
                    break;
                case 0:
                    double x = -b / 2 * a;
                    answer += x.ToString();
                    break;
                case < 0:
                    answer = "Корней нет";
                    break;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine((a == 0) ? (-c / b).ToString() : F(a, b, c));

        }
    }
}
