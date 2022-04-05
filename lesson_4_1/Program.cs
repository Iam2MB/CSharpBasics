using System;
using System.Globalization;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string firstname = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Здравствуйте: {GetFullName(firstname, lastname, patronymic)}");

        }

        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
    }
}