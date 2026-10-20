using System;

namespace Tyuiu.Adzhievrsh.Sprint1.Task4.V19.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            if (x == 2)
            {
                throw new ArgumentException(
                    "При x = 2 знаменатель равен нулю.");
            }

            double result = (x + y) / Math.Abs(x - 2);

            return Math.Round(result, 3);
        }
    }
}