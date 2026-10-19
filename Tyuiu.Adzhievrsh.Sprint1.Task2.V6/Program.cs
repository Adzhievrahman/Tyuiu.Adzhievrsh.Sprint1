using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Adzhievrsh.Sprint1.Task3.V6.Lib;
using Tyuiu.Adzhievrsh.Sprint1.Task3.V6.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                           *");
            Console.WriteLine("* Вариант #6                                                           *");
            Console.WriteLine("* Выполнил: Аджиев Рахман Шахирович | ИИП6-26-1                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Вычислить стоимость поездки на дачу и обратно.                       *");
            Console.WriteLine("* Известны расстояние, расход бензина и цена одного литра.             *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.Write("* Расстояние до дачи (км): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("* Расход бензина (л на 100 км): ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());

            Console.Write("* Цена литра бензина (руб.): ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            double result = ds.TravelCost(distance, gasFlow, gasPrice);

            Console.WriteLine("* Поездка на дачу и обратно обойдется в "
                + result.ToString("F3") + " руб.");

            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}