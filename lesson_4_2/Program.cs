using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через проблел: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Сумма чисел равна: {GetSum(text)}");
        }
        static int GetSum(string numbers)
        {
            string[] array = numbers.Split(' ');
            int sum = 0;

            foreach (string s in array)
            {
                var a = int.Parse(s);
                sum += a;
            }
            return sum;
        }
    }
}
