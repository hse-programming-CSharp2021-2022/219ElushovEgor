using System;
using System.Text;

namespace Task_1
{
    class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size
        {
            get => _duration * _quality;
        }

        public override string ToString()
        {
            return $"name = {_name}\nduration = {_duration}\nquality = {_quality}\nsize = {Size}";
        }
    }
    class Program
    {
        public static string GenerateName()
        {
            var random = new Random();
            var s = new StringBuilder();
            for (var i = 0; i < random.Next(2, 9); i++)
            {
                s.Append((char)random.Next('a', 'z' + 1));
            }

            return s.ToString();
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            var a = new VideoFile(GenerateName(), rand.Next(60, 361), rand.Next(100, 1001));
            var array = new VideoFile[rand.Next(5, 16)];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new VideoFile(GenerateName(), rand.Next(60, 361), rand.Next(100, 1001));
            }

            foreach (var i in array)
            {
                if (i.Size > a.Size)
                    Console.WriteLine(i);
            }
        }
    }
}
