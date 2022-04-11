using System;
using System.IO;

namespace lesson_5_4 //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл - Без рекурсии
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:\dir";
            string dirСontents = @"D:\dirСontents.txt";
           
            if (Directory.Exists(dir))
            {
                File.WriteAllText(dirСontents, string.Empty);
                string[] content = Directory.GetFileSystemEntries(dir, "*", SearchOption.AllDirectories);
                foreach (string i in content)
                {
                    File.AppendAllText(dirСontents, $"{i}\n");
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Такого каталога не существует");
            }
            
            Console.ReadKey(true);
        }
    }
}
