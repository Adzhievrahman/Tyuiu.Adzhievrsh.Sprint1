using System;

using Tyuiu.Adzhievrsh.Sprint1.Task7.V29.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task7.V29
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
                "* Тема: Вычисление математических выражений                               *");
            Console.WriteLine(
                "* Задание #7                                                              *");
            Console.WriteLine(
                "* Вариант #29                                                             *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите x: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка! Введите число.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Введите y: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Ошибка! Введите число.");
                Console.ReadKey();
                return;
            }

            try
            {
                double result = ds.Calculate(x, y);
                Console.WriteLine("* Результат: " + result.ToString("F3"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("* Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}