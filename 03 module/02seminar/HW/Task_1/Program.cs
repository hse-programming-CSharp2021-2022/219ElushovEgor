using System;
namespace Task_1
{
    class Plant
    {
        private double growth;
        private double photosensiuvity;
        private double frostresistance;

        public double Growth
        {
            get { return growth; }
            set { growth = value; }
        }

        public double Photosensiuvity
        {
            get { return photosensiuvity; }
            set
            {
                if (value >= 0 && value <= 100)
                    photosensiuvity = value;
                else photosensiuvity = 0;
            }
        }

        public double Frostresistance
        {
            get { return frostresistance; }
            set
            {
                if (value >= 0 && value <= 100)
                    frostresistance = value;
                else frostresistance = 0;
            }
        }

        public Plant(double growth, double photosensiuvity, double frostresistance)
        {
            Growth = growth;
            Photosensiuvity = photosensiuvity;
            Frostresistance = frostresistance;
        }

        public override string ToString()
        {
            return $"Growth: {Growth}, Photosensivity: {Photosensiuvity}, Frostresistance: {Frostresistance}.";
        }
    }


    class Program
    {
        public static int Swap(Plant x, Plant y)
        {
            return ((int)x.Photosensiuvity == (int)y.Photosensiuvity) ? x.Photosensiuvity.CompareTo(y.Photosensiuvity) : (int)x.Photosensiuvity.CompareTo((int)y.Photosensiuvity);
        }

        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Введите число n(количество растений):");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введите число:");
            }
            Plant[] arrayPlants = new Plant[n];
            for (var i = 0; i < n; i++)
            {
                arrayPlants[i] = new Plant(random.Next(25, 101), random.Next(0, 101), random.Next(0, 81));
            }
            Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));

            Array.Sort(arrayPlants, delegate (Plant plant, Plant plant1) { return plant.Growth > plant1.Growth ? -1 : 1; });
            Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));

            Array.Sort(arrayPlants, (plant, plant1) => plant.Growth < plant1.Growth ? -1 : 1);
            Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));

            Array.Sort(arrayPlants, Swap);
            Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));

            Array.ConvertAll(arrayPlants, plant => plant.Frostresistance = (plant.Frostresistance % 2 == (0)) ? plant.Frostresistance / 3 : plant.Frostresistance / 2);
            Array.ForEach(arrayPlants, plant => Console.WriteLine(plant));
        }
    }
}