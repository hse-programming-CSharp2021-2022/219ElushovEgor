using System;

namespace Task_2
{

    abstract class Animal
    {
        public string Type;
        public Animal(string name, int age)
        {
            AnimalAge = age;
            AnimalName = name;
        }
        public string AnimalName { get; }
        public int AnimalAge { get; }
        public abstract string AnimalSound();
        public abstract string AnimalInfo();
    }
    class Dog : Animal
    {
        public Dog(string name, int age, string type, bool istrained) : base(name, age)
        {
            Type = type;
            isTrained = istrained;
        }
        private string Breed { get; }
        private bool isTrained { get; }
        public override string AnimalInfo()
        {
            return $"Имя Собаки: {AnimalName}\nВозраст Собаки: {AnimalAge}\nПорода Собаки: {Breed}\nЗвук Собаки: {AnimalSound()}";
        }
        public override string AnimalSound()
        {
            return "Woof";
        }
    }
    class Cow : Animal
    {
        public Cow(string name, int age, string type, bool istrained) : base(name, age)
        {
            Type = type;
            isTrained = istrained;
        }
        private string Breed { get; }
        private bool isTrained { get; }
        public override string AnimalInfo()
        {
            return $"Имя коровы: {AnimalName}\nВозраст коровы: {AnimalAge}\nЗвук коровы: {AnimalSound()}";
        }
        public override string AnimalSound()
        {
            return "Moo";
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