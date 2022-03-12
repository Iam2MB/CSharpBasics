using System;

namespace lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            DateTime now = DateTime.Now;
            Console.WriteLine($"Привет, {name}, сегодня {now.ToString("d")}");
        }
    }
}