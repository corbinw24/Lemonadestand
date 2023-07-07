namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Member Variables (CAN DO)
            List<string> weatherConditions = new List<string>
            {
                "Rainy",
                "Stormy",
                "Sunny",
                "Cloudy",
                "Windy"
            };

            foreach(string weatherCondition in weatherConditions)
            {
                Console.WriteLine(weatherCondition);
            }
            
        }
    }
}