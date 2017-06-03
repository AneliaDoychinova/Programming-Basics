using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoliasNum = int.Parse(Console.ReadLine());
            var hyacinthsNum = int.Parse(Console.ReadLine());
            var rosesNum = int.Parse(Console.ReadLine());
            var cactusesNum = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var magnoliasPrice = 3.25;
            var hyacinthsPrice = 4.00;
            var rosesPrice = 3.5;
            var cactusesPrice = 8.00;

            var totalPriceOrder = magnoliasNum * magnoliasPrice + hyacinthsNum * hyacinthsPrice + rosesNum * rosesPrice 
                + cactusesNum * cactusesPrice;

            var taxes = totalPriceOrder * 0.05;

            totalPriceOrder = totalPriceOrder - taxes;

            if (totalPriceOrder >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalPriceOrder - presentPrice)); 
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - totalPriceOrder));
            }

        }
    }
}
