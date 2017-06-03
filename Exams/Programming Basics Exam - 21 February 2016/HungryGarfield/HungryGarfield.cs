using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            var moneyInDollars = decimal.Parse(Console.ReadLine());
            var dollarExchangeRate = decimal.Parse(Console.ReadLine());
            var pizzaPriceLeva = decimal.Parse(Console.ReadLine());
            var lasagnaPriceLeva = decimal.Parse(Console.ReadLine());
            var sandwichPriceLeva = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = decimal.Parse(Console.ReadLine());
            var lasagnaQuantity = decimal.Parse(Console.ReadLine());
            var sandwichQuantity = decimal.Parse(Console.ReadLine());

            var totalPizza = pizzaPriceLeva * pizzaQuantity;
            var totalLasagna = lasagnaPriceLeva * lasagnaQuantity;
            var totalSandwich = sandwichPriceLeva * sandwichQuantity;

            var totalSumLeva = totalLasagna + totalPizza + totalSandwich;
            var totalSumDollars = totalSumLeva / dollarExchangeRate;

            var difference = Math.Abs(totalSumDollars - moneyInDollars);

            if (moneyInDollars >= totalSumDollars)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", difference);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", difference);
            }


        }
    }
}
