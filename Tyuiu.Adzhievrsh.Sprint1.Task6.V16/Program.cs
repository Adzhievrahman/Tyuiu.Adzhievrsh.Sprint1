using System;
using Tyuiu.Adzhievrsh.Sprint1.Task6.V16.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task6.V16
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
                "* Тема: Работа со строками                                                *");
            Console.WriteLine(
                "* Задание #6                                                              *");
            Console.WriteLine(
                "* Вариант #16                                                             *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите текст: ");
            string value = Console.ReadLine() ?? "";

            bool result = ds.CheckSpecSymbols(value);

            if (result)
            {
                Console.WriteLine("* Строка содержит символы ! и ?.");
            }
            else
            {
                Console.WriteLine("* В строке отсутствует ! или ?.");
            }

            Console.ReadKey();
        }
    }
}