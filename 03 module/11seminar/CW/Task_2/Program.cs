using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream =
                   new FileStream("task2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                if(fileStream.Length == 0)
                {
                    var line = "A";
                    var array = System.Text.Encoding.Default.GetBytes(line);
                    fileStream.Write(array, 0, array.Length);
                }
                else               
                {
                    var array = new byte[fileStream.Length];
                    fileStream.Read(array, 0, array.Length);
                    var str = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine(str);
                    var newString = ((char)(str[str.Length - 1] + 1)).ToString();
                    var array2 = System.Text.Encoding.Default.GetBytes(newString);
                    fileStream.Position = array.Length;
                    fileStream.Write(array2, 0, 1);
                }
            }
        }
    }
}