using System;

namespace lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за месяц: ");
            float minTemp = Single.Parse(Console.ReadLine());

            Console.Write("Введите макисмальную температуру за месяц: ");
            float maxTemp = Single.Parse(Console.ReadLine());

            float avgTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine("Средняя темпиратура за месяц: " + avgTemp + "\n");

            int month = 0;
            while (month < 1 || month > 12)
            {
                Console.Write("Введите номер месяца: ");
                month = int.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Месяца с таким номером нет");
                }
            }
                        
            string rain_month = "";
            if ((month == 12 || month == 1 || month == 2) && avgTemp > 0)
            {
                rain_month = " (Дождливый месяц)";
            }

            Console.Write("Месяц: ");
            switch (month)
            {
                case 1:
                    Console.WriteLine($"Январь{rain_month}");
                    break;
                case 2:
                    Console.WriteLine($"Февраль{rain_month}");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine($"Декабрь{rain_month}");
                    break;
            }
            
            if (month % 2 == 0)
            {
                Console.WriteLine("Номер четный");
            }
            else
            {
                Console.WriteLine("Номер нечетный");
            }
        }
    }
}
