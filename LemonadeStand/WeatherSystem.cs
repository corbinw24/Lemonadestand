using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class WeatherSystem
    {
        //Member variable (Has A)
        public string Condition;
        public int Temperature;
        private List<string> weatherCondition;
        public string predictedForecast;

        //Constructor (Spawner)
        public WeatherSystem(string condition, int Temperature, string predictedForecast, List<string> weatherCondition) 
        {
            this.Condition = condition;
            this.Temperature = Temperature;
            this.weatherCondition = weatherCondition;
            this.predictedForecast = predictedForecast;
        }

        //Member Methods (CAN DO)
        public void PredictWeathercondition()
        {
            Console.WriteLine($"Today's weather condition is [Sunny]");
        }
        public void PredictTemperature()
        {
            Console.WriteLine("Today's temperature is [85] degrees");
        }
        
    }
}
