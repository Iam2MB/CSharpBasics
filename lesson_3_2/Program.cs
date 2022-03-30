using System;

namespace lesson_3_2
{
    internal class Program_2
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[5, 2]
            {
                {"Mr. Orange", "+7(900)5332247/orange@dogs.com"},
                {"Mr. Blonde", "+7(900)5332247/blonde@dogs.com"},
                {"Mr. Pink",   "+7(900)5332247/pink@dogs.com"},
                {"Mr. Blue",   "+7(900)5332247/blue@dogs.com"},
                {"Mr. Brown",  "+7(900)5332247/brown@dogs.com"}
            };
            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    Console.Write(phonebook[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}