using System;

namespace lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную темпиратуру за день:");
            string minTemp = Console.ReadLine();

            Console.WriteLine("Введите макисмальну темпиратуру за день:");
            string maxTemp = Console.ReadLine();

            double avg = (Double.Parse(minTemp) + Double.Parse(maxTemp)) / 2;
            Console.WriteLine("Средняя темпиратура за день :" + avg);

            Console.WriteLine("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("moth1");
                    break;
                case 2:
                    Console.WriteLine("moth12");
                    break;
                case 3:
                    Console.WriteLine("moth13");
                    break;
                case 4:
                    Console.WriteLine("moth14");
                    break;
                case 5:
                    Console.WriteLine("moth15");
                    break;
                case 6:
                    Console.WriteLine("moth16");
                    break;
                case 7:
                    Console.WriteLine("moth17");
                    break;
                case 8:
                    Console.WriteLine("moth18");
                    break;
                case 9:
                    Console.WriteLine("moth19");
                    break;
                case 10:
                    Console.WriteLine("moth110");
                    break;
                case 11:
                    Console.WriteLine("moth112");
                    break;
                case 12:
                    Console.WriteLine("moth111");
                    break;
                default:
                    Console.WriteLine("Нет такого месяца");
                    break;
            }
            if ((month == 12 || month == 1 || month == 2) && avg > 0) Console.WriteLine("Ты пидор");
        }
    }
}
