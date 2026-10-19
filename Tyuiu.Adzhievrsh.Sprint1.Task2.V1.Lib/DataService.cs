using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Adzhievrsh.Sprint1.Task2.V1.Lib

{
    public class DataService: ISprint1Task2V1
    {
     
        public double ConvertKmToM(int value)
        {
            double miles = value / 1.609;
            return Math.Round(miles, 3);
        }
    }
}