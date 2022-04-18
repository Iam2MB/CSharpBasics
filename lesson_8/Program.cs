using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Properties.Settings.Default.ApplicationName;
            lesNumFio.PrintInfo(8, "Мирзаев Мирза Баширович");
            Console.WriteLine(Properties.Settings.Default.Greeting);

            if (Properties.Settings.Default.UserName == null)
            {
                Console.Write("Введите ваше имя: ");
                string userName = Console.ReadLine();
                Properties.Settings.Default.UserName = userName;

                Console.Write("Введите ваш возраст: ");
                int userAge = int.Parse(Console.ReadLine());
                Properties.Settings.Default.UserAge = userAge;

                Console.Write("Введите ваш род деятельности: ");
                string userActivity = Console.ReadLine();
                Properties.Settings.Default.UserActivity = userActivity;
                Properties.Settings.Default.Save();

                Console.WriteLine("\nСпасибо за информацию\n");
            }
            else
            {
                Console.WriteLine("Меня зовут:\t" + Properties.Settings.Default.UserName);
                Console.WriteLine("Мой возраст:\t" + Properties.Settings.Default.UserAge);
                Console.WriteLine("Моя должность:\t" + Properties.Settings.Default.UserActivity);
            }
            
            Console.WriteLine("Версия проложения: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

            Console.ReadKey(true);
        }
    }
}
