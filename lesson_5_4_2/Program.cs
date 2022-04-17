using System;
using System.IO;
using System.Text.Json;

namespace lesson_5_4_2 //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл - с рекурсией
{
    internal class Program 
    {
        public static string dirСontents = @"D:\dirСontents.txt";

        static void Main(string[] args)
        {
            if (File.Exists(dirСontents))
            {
                File.WriteAllText(dirСontents, string.Empty);
            }

            DirectoryInfo dir = new DirectoryInfo(@"d:\dir");
            GetPath(dir);

            Console.ReadKey(true);
        }

        static void GetPath(DirectoryInfo dir) 
        {
            Console.WriteLine(dir.FullName);
            File.AppendAllText(dirСontents, dir.FullName + "\n");

            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < dirs.Length; i++)
            {
                GetPath(dirs[i]);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i].FullName);
                File.AppendAllText(dirСontents, files[i].FullName + "\n");
            }
        }
    }
}
