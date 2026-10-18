using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Adzhievrsh.Sprint1.Task0.V27.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task0.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0  |Выполнил: Аджиев Р. Ш. |ИИП6 - 26 - 1";


            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: работа на с#                                                   *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #27                                                          *");
            Console.WriteLine("* Выполнил: Аджиев Рахман Шахирович | ИИП6-26-1                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет выржение  5*2 + 4*3             *");
            Console.WriteLine("* и печатает результат на экране.                                       *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* 5*2 + 4*3                                                            *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}