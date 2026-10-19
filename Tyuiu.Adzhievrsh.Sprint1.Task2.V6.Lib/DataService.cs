using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Adzhievrsh.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            double totalDistance = distance * 2;
            double fuelNeeded = totalDistance * gasFlow / 100;
            double cost = fuelNeeded * gasPrice;

            return Math.Round(cost, 3);
        }
    }
}