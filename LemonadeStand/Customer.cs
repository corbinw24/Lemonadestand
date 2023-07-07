using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        //Member Variable (HAS A)
        public string Name { get; set; }
        public double ChanceOfBuying { get; set; }
        public double MaxPrice { get; set; }
        
        //Constructor
        public Customer(string name, double chanceOfBuying, double maxPrice)
        {
            Name = name;
            ChanceOfBuying = chanceOfBuying;
            MaxPrice = maxPrice;
        }

        //Member Methods (CAN DO)
        public bool WillBuyLemonade()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();

            if (randomNumber < ChanceOfBuying)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetOfferedPrice()
        {
            Random random = new Random();
            double offeredPrice = random.NextDouble() * MaxPrice;

            return offeredPrice;
        }
    }

    class LemonadeStand
    {
        static void Main()
        {
            // Create an array of customer objects
            Customer[] customers = new Customer[3];

            customers[0] = new Customer("John", 0.7, 2.5);
            customers[1] = new Customer("Jane", 0.5, 3.0);
            customers[2] = new Customer("Bob", 0.3, 1.8);

            // Simulate selling lemonade to each customer
            for (int i = 0; i < customers.Length; i++)
            {
                Customer customer = customers[i];

                if (customer.WillBuyLemonade())
                {
                    double price = customer.GetOfferedPrice();
                    Console.WriteLine("{0} wants to buy lemonade for {1:C}", customer.Name, price);
                }
                else
                {
                    Console.WriteLine("{0} doesn't want to buy lemonade.", customer.Name);
                }
            }

            Console.ReadLine();
        }
    }

}

