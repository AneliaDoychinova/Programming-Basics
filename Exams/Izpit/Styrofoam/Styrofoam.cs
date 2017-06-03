using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowsNum = int.Parse(Console.ReadLine());
            var styrofoamMeters = double.Parse(Console.ReadLine());
            var styrofoamPrice = double.Parse(Console.ReadLine());

            var area = houseArea - windowsNum * 2.4;
            area = area * 1.1;
            var packageNeeded = Math.Ceiling(area / styrofoamMeters);
            var totalMoney = packageNeeded * styrofoamPrice;

            var difference = Math.Abs(budget - totalMoney);

            if (budget >= totalMoney)
            {
                Console.WriteLine("Spent: {0:f2}", totalMoney);
                Console.WriteLine("Left: {0:f2}", difference);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", difference);
            }
        }
    }
}
