using System;

namespace Task_1
{
    public delegate void NewStringValue(string s);

    public class UIString
    {
        string str = "Default text";
        public string Str { get { return str; } private set { str = value; } }

        public void NewStringValueHappenedHandler(string s)
        {
            str = s;
        }
    }

    class ConsoleUI
    {

        UIString s = new UIString();
        public UIString S { get { return s; } set { s = value; } }
        public void GetStringFromUI()
        {
            Console.Write("Введите новое значение строки: ");
            string str = Console.ReadLine();
            NewStringValueHappened?.Invoke(str);
            RefreshUI();
        }

        public event NewStringValue NewStringValueHappened;
        public void CreateUI()
        {
            NewStringValueHappened += S.NewStringValueHappenedHandler;
            RefreshUI();
        }
        public void RefreshUI() {
            Console.Clear();
            Console.WriteLine("Текст строки: " + s.Str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI c = new ConsoleUI();
            c.CreateUI();
            do
            {
                c.GetStringFromUI(); 
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}