using System;

namespace Task_3
{
    abstract class Animal
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Animal(int age)
        {
            Age = age;
        }
    }

    public interface IRun
    { string Run(); }

    public interface IJump
    { string Jump(); }

    class Cockroach : Animal, IRun
    {
        private int speed;

        public Cockroach(int age, int speed) : base(age)
        { this.speed = speed; }

        public string Run()
        { return string.Format($"Скорость таракана: {speed}."); }
    }

    class Kangaroo : Animal, IJump
    {
        private int height;

        public Kangaroo(int age, int height) : base(age)
        { this.height = height; }

        public string Jump()
        {
            return string.Format($"Высота прыжка кенгуру: {height}.");
        }
    }

    class Cheetah : Animal, IRun, IJump
    {
        private int speed;
        private int height;

        public Cheetah(int age, int speed, int height) : base(age)
        {
            this.height = height;
            this.speed = speed;
        }

        public string Run()
        { return string.Format($"Скорость гепарда: {speed}."); }

        public string Jump()
        { return string.Format($"Высота прыжка гепрада: {height}."); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[5];
            animal[0] = new Cockroach(3, 7);
            animal[1] = new Kangaroo(10, 2);
            animal[2] = new Cheetah(4, 5, 5);
            foreach (var animals in animal)
            {
                if (animals is IJump)
                    Console.WriteLine(((IJump)animals).Jump());

                if (animals is IRun)
                    Console.WriteLine(((IRun)animals).Run());
            }
        }
    }
}