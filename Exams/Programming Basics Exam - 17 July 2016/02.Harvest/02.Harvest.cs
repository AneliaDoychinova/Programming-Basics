using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyardArea = int.Parse(Console.ReadLine());
            var grapeForSquareMeter = double.Parse(Console.ReadLine());
            var wineLitersNeeded = int.Parse(Console.ReadLine());
            var workersNum = int.Parse(Console.ReadLine());

            var grapeNeededForLiterWine = 2.5;

            var totalGrape = vineyardArea * grapeForSquareMeter;
            var wine = totalGrape * 0.4 / grapeNeededForLiterWine;

            if (wine >= wineLitersNeeded)
            {
                var wineLeft = wine - wineLitersNeeded;
                var winePerWorker = wineLeft / workersNum;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft),Math.Ceiling(winePerWorker));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineLitersNeeded - wine));
            }


        }
    }
}
