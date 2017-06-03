using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVeggies = double.Parse(Console.ReadLine());
            var priceFruits = double.Parse(Console.ReadLine());
            var kgVeggies = int.Parse(Console.ReadLine());
            var kgFruits = int.Parse(Console.ReadLine());

            var veggies = priceVeggies * kgVeggies;
            var fruits = priceFruits * kgFruits;

            double euro = (veggies + fruits) / 1.94;
            Console.WriteLine(euro);
        }
    }
}
