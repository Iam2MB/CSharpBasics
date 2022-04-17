using System;

namespace lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();

            while (input == password == false)
            {
                Console.WriteLine("Invalid password!\n");
                Console.WriteLine("Enter password again:");
                input = Console.ReadLine();
            }

            Console.WriteLine("Welcome!");
            Console.ReadKey(true);
        }
    }
}
