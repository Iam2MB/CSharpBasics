using System;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Число Фибоначчи для заданного значения равно: {Fib(num)}");
            Console.ReadKey();
        }

        static int Fib(int numFib)
        {
            if (numFib == 0 || numFib == 1)
            {
                return numFib;
            }
            else
            {
                return Fib(numFib - 1) + Fib(numFib - 2);
            }
        }
    }
}