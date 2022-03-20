using System;

namespace Task_3
{
    class Program
    {
        delegate string ConvertRule(string n);

        public static string RemoveDigits(string str)
        {
            string s = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    s += str[i];
                }
            }
            return s;
        }

        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }

        static void Main(string[] args)
        {
            string[] n = { "123qwerty", "hello  world 1239joasd" };
            ConvertRule t = RemoveDigits;
            t = t + RemoveSpaces;
            for (int i = 0; i < n.Length; i++)
            {
                foreach (ConvertRule num in t.GetInvocationList())
                {
                    Console.WriteLine(num(n[i]));
                }
            }
        }
    }
}