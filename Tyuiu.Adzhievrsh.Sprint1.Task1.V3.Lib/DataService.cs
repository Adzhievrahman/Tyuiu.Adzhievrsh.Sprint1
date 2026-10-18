using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Adzhievrsh.Sprint1.Task1.V3.Lib
{

    public class DataService : ISprint1Task1V3
    {
        public double Calculate(double x, double y)
        {
            return (x - y) / (x + 3) + 3;
        }
    }
}