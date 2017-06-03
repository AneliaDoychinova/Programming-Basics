using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            var priceForVegetables = double.Parse(Console.ReadLine());
            var priceForFruits = double.Parse(Console.ReadLine());
            var totalKilosVegetables = int.Parse(Console.ReadLine());
            var totalKilosFruits = int.Parse(Console.ReadLine());

            var totalIncomeLeva = priceForVegetables * totalKilosVegetables + priceForFruits * totalKilosFruits;
            var totalIncomeEuro = totalIncomeLeva / 1.94;

            Console.WriteLine(totalIncomeEuro);

        }
    }
}
