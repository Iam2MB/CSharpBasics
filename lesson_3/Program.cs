using System;

namespace lesson_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte size = 5;
            int[,] array = new int[size, size];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }            
                       
        }
    }
}