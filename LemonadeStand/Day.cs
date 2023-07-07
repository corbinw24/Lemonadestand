using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        //Member Variables (HAS A)
        public string Weather;
        public List<Customer> Customers;

        //Constructor 
        public Day()
        {
            Weather weather = new Weather();
        }

        //Member Methods (CAN DO)
        public void DisplayTemperature()
        {
            Console.WriteLine("The current temperature is [85] degrees");
        }



    }
}
