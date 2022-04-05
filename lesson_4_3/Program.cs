using System;

namespace test4
{
    internal class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }

        static void Main(string[] args)
        {
            int monthNum = 0;
            while (1 > monthNum || monthNum > 12)
            {
                Console.WriteLine("Введите номер месяца: ");
                monthNum = int.Parse(Console.ReadLine());
                if (1 > monthNum || monthNum > 12)
                {
                    Console.WriteLine("Месяца с таким номером нет\n");
                }
            }

            if (monthNum == 1 || monthNum == 2 || monthNum == 12)
            {
                Console.WriteLine(Season.Winter);
            }
            else if (monthNum == 3 || monthNum == 4 || monthNum == 5)
            {
                Console.WriteLine(Season.Spring);
            }
            else if (monthNum == 6 || monthNum == 7 || monthNum == 8)
            {
                Console.WriteLine(Season.Summer);
            }
            else if (monthNum == 9 || monthNum == 10 || monthNum == 11)
            {
                Console.WriteLine(Season.Autumn);
            }

        }
    }
}