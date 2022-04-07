using System;
using System.IO;

namespace lesson_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "lesson5.txt";
            string fileStartup = "startup.txt";
            DateTime start = DateTime.Now;

            File.WriteAllText(fileName, Console.ReadLine());    //задание 1
            
            if (File.Exists(fileStartup))                       //звдвние 2
            {
                File.AppendAllText(fileStartup, start.ToString());   
                File.AppendAllText(fileStartup, Environment.NewLine);
            }
            else
            {
                File.Create(fileStartup);
            }
            
                      

            Console.WriteLine(File.ReadAllText(fileStartup));

        }
    }
}
