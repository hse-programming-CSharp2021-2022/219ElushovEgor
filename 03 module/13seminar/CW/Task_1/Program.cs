using System;
using System.Collections;

namespace Task_1
{
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Thursday", "Wednsday" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
    
    class Week2 : IEnumerable
    {
        string[] days = { "Monday", "Thursday", "Wednsday", "geree", "fewfwt4", "agreergi" };
        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
        class WeekEnumerator : IEnumerator
        {
            string[] days;
            int position = -1;
            static Random random = new Random();
            public WeekEnumerator(string[] days)
            {
                this.days = days;
            }
            public object Current => days[position];
            public bool MoveNext()
            {
                if (position < days.Length - 1)
                {
                    position = random.Next(0, days.Length);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Reset()
            {
                position = -1;
            }
        }
    }
    class ArProgression : IEnumerable
    {
        int d, a0;
        public ArProgression(int d, int a0)
        {
            this.d = d; this.a0 = a0;
        }
        public IEnumerator GetEnumerator()
        {
            return new ArProgressionEnumerator(d, a0);
        }
        public IEnumerable NextElement(int n)
        {
            return new ArProgressionEnumerator(d, a0, n);
        }
        public IEnumerable NextElementYield(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return a0 + d * i;
            }
        }
        class ArProgressionEnumerator : IEnumerator, IEnumerable
        {
            int d, a0, n;
            int pos = -1;
            public ArProgressionEnumerator(int d, int a0, int n = 10)
            {
                this.d = d; this.a0 = a0; this.n = n;
            }
            public object Current => a0 + d * pos;
            public IEnumerator GetEnumerator()
            {
                return this;
            }
            public bool MoveNext()
            {
                if (pos < n - 1)
                {
                    pos++;
                    return true;
                }
                return false;
            }
            public void Reset()
            {
                pos = -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArProgression arProgression = new ArProgression(10, 10);
            foreach (int el in arProgression)
            {
                Console.WriteLine(el);
            }
            foreach (int el in arProgression.NextElement(20))
            {
                Console.WriteLine(el);
            }
            foreach (int el in arProgression.NextElementYield(20))
            {
                Console.WriteLine(el);
            }
        }
    }
}