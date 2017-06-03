using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            var water = 20.0;
            var internet = 15.0;
            var totalOthers = 0.0;
            var totalCurrent = 0.0;

            for (int i = 0; i < months; i++)
            {
               var current = double.Parse(Console.ReadLine());
               totalCurrent += current;
               var others = (current + water + internet) * 1.2;
               totalOthers += others;
                

            }
            var totalWater = months * water;
            var totalInternet = months * internet;
            var average = (totalWater + totalInternet + totalCurrent + totalOthers) / months;

            Console.WriteLine("Electricity: {0:f2} lv", totalCurrent);
            Console.WriteLine("Water: {0:f2} lv", totalWater);
            Console.WriteLine("Internet: {0:f2} lv", totalInternet);
            Console.WriteLine("Other: {0:f2} lv", totalOthers);
            Console.WriteLine("Average: {0:f2} lv", average);

        }
    }
}
