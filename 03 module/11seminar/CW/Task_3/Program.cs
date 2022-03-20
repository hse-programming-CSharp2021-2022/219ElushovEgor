using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fStream = new FileStream("1000.txt", FileMode.OpenOrCreate))
            {
                var len = fStream.Length;
                if (len <= 3)
                {
                    byte[] toWrite = { (byte)((byte)'A' + len) };
                    fStream.Position = len;
                    fStream.Write(toWrite, 0, 1);
                }
            }
            using (var fStream = new FileStream("1000.txt", FileMode.Open))
            {
                var next = 0;
                while (next != -1)
                {
                    next = fStream.ReadByte();
                    byte[] read = { (byte)next };
                    if (next != -1)
                        Console.Write(System.Text.Encoding.Default.GetString(read) + " ");
                }
            }
        }
    }
}