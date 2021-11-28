using System;

namespace Task_5
{
    public class ConsolePlate
    {
        char _plateChar;
        ConsoleColor _plateColor = ConsoleColor.White, _backgroundColor = ConsoleColor.Black;

        public ConsolePlate()
        {
            _plateChar = 'A';
        }

        public ConsolePlate(char plateChar='A', ConsoleColor plateColor= ConsoleColor.White, 
            ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            this.PlateChar = plateChar;
            this.PlateColor = plateColor;
            this.BackgroundColor = backgroundColor;
        }

        public char PlateChar
        {
            set
            {
                if (value >= 'A' && value <= 'Z')
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get { return _plateChar; }
        }
        public ConsoleColor PlateColor
        {
            set { _plateColor = value; }
            get => _plateColor;
        }

        public ConsoleColor BackgroundColor
        {
            set
            {
                if (value == _plateColor)
                    _backgroundColor = _plateColor + 1;
                else
                    _backgroundColor = value;
            }
            get => _backgroundColor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cp = new ConsolePlate();
            ConsolePlate[] somePlates =
            {        
                new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red),
                new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta)
            };
            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.BackgroundColor = somePlates[(i + j) % 2].BackgroundColor;
                    Console.ForegroundColor = somePlates[(i + j) % 2].PlateColor;
                    Console.Write(somePlates[(i + j) % 2].PlateChar);
                }
                Console.WriteLine();
            }
        }
    }
}
