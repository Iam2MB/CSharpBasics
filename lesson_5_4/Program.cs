using System;
using System.IO;

namespace lesson_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:\Dir";
            string dirСontents = @"D:\dirСontents.txt";
                        
            if (Directory.Exists(dir))
            {
                if (File.Exists(dirСontents))
                {
                    File.WriteAllText(dirСontents, string.Empty);
                    string[] content = Directory.GetFileSystemEntries(dir, "*", SearchOption.AllDirectories);
                    foreach (string i in content)
                    {
                        File.AppendAllText(dirСontents, i);
                        File.AppendAllText(dirСontents, Environment.NewLine);
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    File.Create(dirСontents);
                }
            }
            else
            {
                Console.WriteLine("Такого каталога не существует");
            }
            
            Console.ReadKey();
        }
    }
}
