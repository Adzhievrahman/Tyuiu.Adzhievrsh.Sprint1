using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Adzhievrsh.Sprint1.Task4.V19.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Аджиев Р.Ш. | ИИП6-26-1";

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт №1                                                            *");
            Console.WriteLine("* Тема: работа на C#                                                   *");
            Console.WriteLine("* Задание #4                                                           *");
            Console.WriteLine("* Вариант #19                                                          *");
            Console.WriteLine("* Выполнил: Аджиев Рахман Шахирович | ИИП6-26-1                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Вычислить выражение (x + y) / |x - 2|.                               *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.Write("* Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("* Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            if (x == 2)
            {
                Console.WriteLine("* Ошибка: при x = 2 знаменатель равен нулю.                             *");
            }
            else
            {
                double result = ds.Calculate(x, y);

                Console.WriteLine("* Результат: " + result.ToString("F3"));
            }

            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}