using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            if (k <= 0)
            {
                throw new ArgumentException(
                    "Число должно быть положительным.");
            }

            return (k / 100) % 10;
        }
    }
}