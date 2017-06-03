using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysNum = int.Parse(Console.ReadLine());
            var foodLeftKg = int.Parse(Console.ReadLine());
            var dogFoodForDayKg = double.Parse(Console.ReadLine());
            var catFoodForDayKg = double.Parse(Console.ReadLine());
            var turtleFoodForDayGr = double.Parse(Console.ReadLine());

            var dogFoodNeeded = daysNum * dogFoodForDayKg;
            var catFoodNeeded = daysNum * catFoodForDayKg;
            var turtleFoodNeeded = daysNum * turtleFoodForDayGr / 1000;

            var totalFoodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

            if (foodLeftKg >= totalFoodNeeded)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeftKg - totalFoodNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFoodNeeded - foodLeftKg));
            }

        }
    }
}
