using System;
using Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Task #5 | Вариант 3";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #1                                       *");
            Console.WriteLine("*  Task #5                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            Console.Write("Введите положительное целое число k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            DataService service = new DataService();
            int h = service.Calculate(k);

            Console.WriteLine($"Третья цифра с конца h = {h}");
            Console.ReadKey();
        }
    }
}