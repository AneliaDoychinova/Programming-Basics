using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var location = "";
            var place = "";
            var price = 0.0;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.65 * budget;
                }
                else
                {
                    location = "Morocco";
                    price = 0.45 * budget;
                }
            }
            else if (budget <=3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.8 * budget;
                }
                else
                {
                    location = "Morocco";
                    price = 0.6 * budget;
                }
            }
            else
            {
                place = "Hotel";
                price = 0.9 * budget;
                if (season == "Summer")
                {
                    location = "Alaska";
                    
                }
                else
                {
                    location = "Morocco";
                  
                }
            }
            Console.WriteLine("{0} - {1} - {2:f2}", location,place, price);
        }
    }
}
