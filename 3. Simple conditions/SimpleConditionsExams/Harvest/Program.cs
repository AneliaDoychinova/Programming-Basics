using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaVineyard = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var wineNeeded = int.Parse(Console.ReadLine());
            var workersNum = int.Parse(Console.ReadLine());

            var grapeSum = areaVineyard * grape;
            var wine = grapeSum * 0.4 / 2.5;

            if (wine >= wineNeeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - wineNeeded), Math.Ceiling((wine - wineNeeded) / workersNum));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineNeeded - wine));
            }

        }
    }
}
