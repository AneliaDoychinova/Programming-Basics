using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var classes = "";
            var car = "";
            var price = 0.0;

            if (budget <= 100)
            {
                classes = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = 0.35 * budget;
                }
                else
                {
                    car = "Jeep";
                    price = 0.65 * budget; 
                }
            }
            else if (budget <= 500)
            {
                classes = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = 0.45 * budget;
                }
                else
                {
                    car = "Jeep";
                    price = 0.8 * budget; 
                }
            }
            else
            {
                classes = "Luxury class";
                car = "Jeep";
                price = 0.9 * budget;
            }

            Console.WriteLine(classes);
            Console.WriteLine("{0} - {1:f2}", car, price);
        }
    }
}
