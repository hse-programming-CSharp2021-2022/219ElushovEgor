using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Task1
{

    abstract class Person
    {
        public Random random = new Random();
        public string Name { get; set; }
        public  string Pocket { get; set; }

        public abstract void Receive(string Present);

        public Person(string name)
        {
            Name = name;
            Pocket = string.Empty;
        }

        public override string ToString()
        {
            return $"Name = {Name} Pocket = {Pocket}";
        }
    }

    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name)
        {
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
            {
                Pocket = present;
            }
            else
            {
                throw new ArgumentException(">1 gifts");
            }
        }

        private string CreateString()
        {
            int n = random.Next(4, 11);
            StringBuilder s = new StringBuilder();
            for (var i = 0; i < n; i++)
                s.Append(random.Next('a', 'z' + 1));
            return s.ToString();
        }

        public string[] CreatePresents(int amount)
        {
            var gifts = new string[amount];
            for (var i = 0; i < amount; i++)
                gifts[i] = CreateString();
            return gifts;
        }
    }

    class Santa : Person
    {
        private List<string> sack;

        public void Request(SnowMaiden snowMaiden, int amount)
        {
            sack.AddRange(snowMaiden.CreatePresents(amount));
        }

        public Santa(string name) : base(name)
        {
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
            {
                Pocket = present;
            }
            else
            {
                throw new ArgumentException(">1 gifts");
            }
        }

        public void Give(Person person)
        {
            var n = random.Next(0, sack.Count);
            if (sack.Count > 0)
            {
                person.Receive(sack[n]);
                sack.RemoveAt(n);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    class Child : Person
    {
        public string AdditionalPocket { get; set; }

        public Child(string name) : base(name)
        {
            AdditionalPocket = string.Empty;
        }

        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
            {
                Pocket = present;
            }
            else if (AdditionalPocket.Equals(string.Empty))
            {
                AdditionalPocket = present;
            }
            else
            {
                throw new ArgumentException(">2 gifts");
            }
        }
        public override string ToString()
        {
            return $"Name = {Name} Pocket1 = {Pocket} Pocket2 = {AdditionalPocket}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var santa = new Santa("Santa");
            var snowMaiden = new SnowMaiden("SnowMaiden");
            var n = 10;
            var people = new List<Person>(n + 2);
            people.Add(santa);
            people.Add(snowMaiden);
            for (var i = 2; i < n + 2; i++)
            {
                people[i] = new Child(i.ToString());
            }
            Console.WriteLine("***");

            for (var i = 2; i < n + 2; i++)
            {
                Console.WriteLine(people[i]);
            }
            Console.WriteLine("***");

            Random random = new Random();
            for (var i = 0; i < n + 1; i++)
            {
                var prob = random.Next(0, 101);
                if (prob < 10)
                {
                    santa.Give(people[0]);
                }
                else
                {
                    santa.Give(people[i]);
                    santa.Request(snowMaiden, random.Next(1, 5));
                }
            }
        }
    }
}
