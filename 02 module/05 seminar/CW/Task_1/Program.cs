using System;

namespace Task_1
{
    abstract class Animal
    {
        private string Name { get; set; }
        private string Sound { get; set; }

        public abstract void AnimalSound();
        public abstract void AnimalInfo();
    }

    class Dog : Animal
    {
        public override void AnimalInfo()
        {
            throw new NotImplementedException();
        }

        public override void AnimalSound()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
