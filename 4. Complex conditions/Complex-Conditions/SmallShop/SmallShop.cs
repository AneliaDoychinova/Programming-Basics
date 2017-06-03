using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var coffePrice = 0.0;
            var waterPrice = 0.0;
            var beerPrice = 0.0;
            var sweetsPrice = 0.0;
            var peanutsPrice = 0.0;

            switch (town)
            {
                case "sofia":
                   
                    coffePrice = 0.5;
                    waterPrice = 0.8;
                    beerPrice = 1.2;
                    sweetsPrice = 1.45;
                    peanutsPrice = 1.60;
                    break;

                case "plovdiv":
                    coffePrice = 0.4;
                    waterPrice = 0.7;
                    beerPrice = 1.15;
                    sweetsPrice = 1.30;
                    peanutsPrice = 1.50;
                    break;

                case "varna":
                    coffePrice = 0.45;
                    waterPrice = 0.7;
                    beerPrice = 1.1;
                    sweetsPrice = 1.35;
                    peanutsPrice = 1.55;
                    break;
            }

            var price = 0.0;
            if (product == "coffee")
            {
                price = coffePrice;
            }
            else if (product == "water")

	        {
                price = waterPrice;
	        }
            else if (product == "beer")
            {
                price = beerPrice;
            }
            else if (product == "sweets")
            {
                price = sweetsPrice;
            }
            else if (product == "peanuts")
            {
                price = peanutsPrice;
            }

            Console.WriteLine(quantity * price);
        }
    }
}
