using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();

            var price = 0.0;
            var taxiDay = 0.79;
            var taxiNight = 0.90;
            var taxiFirstPrice = 0.7;
            var bus = 0.09;
            var train = 0.06;

            if (km < 20)
            {
                if (timeOfDay == "day")
                {
                    price = km * taxiDay + taxiFirstPrice;
                }
                else
                {
                    price = km * taxiNight + taxiFirstPrice;
                }
            }
            else if (km >= 100)
            {
                price = km * train;
            }
            else if (km >= 20)
            {
                price = km * bus;
            }

            Console.WriteLine(price);
        }
    }
}
