using System;
using static System.Console;

namespace lesson_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Введите строку: "); 
            string str = ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = String.Join("", arr);
            WriteLine($"Строка в обратном порядке: {str}");
        }
    }
}