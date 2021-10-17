using System;

namespace SW
{
    internal class Program
    {
        private static void Transform(ref uint numb)
        {
            uint n = 0;
            for (uint i = 0; numb != 0; i++)
            {
                if (numb % 10 == 0)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 1)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 2)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 3)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 4)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 5)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 6)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 7)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 8)
                {
                    n += 10 * i * (numb % 10);
                }
                else if (numb % 10 == 9)
                {
                    n += 10 * i * (numb % 10);
                }

                numb /= 10;
            }

            numb = n;
        }
        
        public static void Main(string[] args)
        {
            uint N;
            N = uint.Parse(Console.ReadLine() ?? string.Empty);
            Transform(ref N);
            Console.WriteLine(N);
        }
    }
}