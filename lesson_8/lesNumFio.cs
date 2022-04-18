using System;

namespace lesson_8
{
    public static class lesNumFio
    {
        public static void PrintInfo(int number, string fio)
        {
            Console.WriteLine($"Домашняя работа, Урок {number}");
            string HomeworkFio = $"Студент: {fio}";
            Console.WriteLine(HomeworkFio);
            for (int i = 0; i < HomeworkFio.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
        }
    }
}
