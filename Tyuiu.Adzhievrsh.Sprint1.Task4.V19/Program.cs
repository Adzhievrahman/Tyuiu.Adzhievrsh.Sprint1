using System;
using Tyuiu.Adzhievrsh.Sprint1.Task4.V19.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task4.V19
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
                "* Тема: Операции с вещественными числами                                  *");
            Console.WriteLine(
                "* Задание #4                                                              *");
            Console.WriteLine(
                "* Вариант #19                                                             *");
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

            if (x == 2)
            {
                Console.WriteLine(
                    "Ошибка! При x = 2 знаменатель равен нулю.");
            }
            else
            {
                double result = ds.Calculate(x, y);
                Console.WriteLine(
                    "* Результат: " + result.ToString("F3"));
            }

            Console.ReadKey();
        }
    }
}