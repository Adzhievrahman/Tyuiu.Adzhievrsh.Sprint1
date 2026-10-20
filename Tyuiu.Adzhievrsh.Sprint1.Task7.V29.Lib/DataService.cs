using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Adzhievrsh.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            {
                double denominator1 = x * y - 3;
                double denominator2 = x * y + 5;

                if (denominator1 == 0 || denominator2 == 0)
                {
                    throw new ArgumentException(
                        "Знаменатель не должен быть равен нулю.");
                }

                double result = x
                    - Math.Cos(Math.Pow(x, 3)) / denominator1
                    + Math.Sin(Math.Pow(x, 5)) / denominator2;

                return Math.Round(result, 3);
            }
        }
    }
}