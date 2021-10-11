using System;

namespace Task_4
{
    class Program
    {

        static void Sums (uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            uint number_1 = number;
            for (; number_1 != 0; number_1 /= 100)
            {
                sumEven += number_1 % 10;
            }
            number /= 10;
            for (; number != 0; number /= 100)
            {
                sumOdd += number % 10;
            }
        }
        static void Main(string[] args)
        {
            uint sumEven;
            uint sumOdd;
            uint n;
            n = uint.Parse(Console.ReadLine());
            Sums(n, out sumEven, out sumOdd);
            Console.WriteLine(sumOdd + " " + sumEven);
        }
    }
}
