using System;
using static System.Console;

namespace lesson_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] battleships = new string[10, 10]
            {
                {"X","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","X","X","O","O","O","O"},
                {"O","O","X","O","O","O","O","O","X","O"},
                {"O","O","O","O","O","O","O","O","X","O"},
                {"O","X","O","O","X","O","O","O","X","O"},
                {"O","X","O","O","O","O","O","O","X","O"},
                {"O","O","O","O","O","O","X","O","O","O"},
                {"O","O","O","X","X","X","O","O","O","O"},
                {"O","X","O","O","O","O","O","O","O","O"},
                {"O","X","O","O","O","O","O","X","X","X"},
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Write(battleships[i,j]);
                }
                WriteLine();
            }
        }
    }
}
