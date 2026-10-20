using System;

using Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title =
                "Спринт #1 | Выполнил: Аджиев Р.Ш. | ИИП6-26-1";

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #1                                                               *");
            Console.WriteLine(
                "* Тема: Работа с целыми числами                                           *");
            Console.WriteLine(
                "* Задание #3                                                              *");
            Console.WriteLine(
                "* Вариант #3                                                              *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("Введите положительное целое число k: ");

            if (int.TryParse(Console.ReadLine(), out int k) && k > 0)
            {
                int h = ds.Calculate(k);
                Console.WriteLine("Третья цифра с конца h = " + h);
            }
            else
            {
                Console.WriteLine(
                    "Ошибка! Введите положительное целое число.");
            }

            Console.ReadKey();
        }
    }
}