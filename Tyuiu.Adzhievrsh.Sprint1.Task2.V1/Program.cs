using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Adzhievrsh.Sprint1.Task2.V1.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task2.V1
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
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #1                                                           *");
            Console.WriteLine("* Выполнил: Аджиев Рахман Шахирович | ИИП6-26-1                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Известно расстояние в километрах. Вычислить расстояние в милях.      *");
            Console.WriteLine("* 1 миля = 1,609 км. Ответ округлить до 3 знаков после запятой.        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.Write("* Введите расстояние в километрах: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("* Расстояние в милях: " + ds.ConvertKmToM(value));

            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}