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
        public WeatherSystem(string condition, int Temperature, string predictedForecast) 
        {
            this.Condition = condition;
            this.Temperature = Temperature;
            this.predictedForecast = predictedForecast;




        }
    }
}
