using System;
using System.IO;

namespace lesson_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string numbStr = Console.ReadLine();
            string[] numbStrArr = numbStr.Split();

            byte[] numbArr = new byte[100];
            for (int i = 0; i < numbStrArr.Length; i++)
            {
                numbArr[i] = Convert.ToByte(numbStrArr[i]);
            }

            string bytes = "bytes.bin";
            File.WriteAllBytes(bytes, numbArr);
        }
    }
}
