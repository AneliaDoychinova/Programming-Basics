using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            var cupsNeeded = int.Parse(Console.ReadLine());
            var workersNum = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var workingHours = workersNum * workingDays * 8;
            var cupsNum = Math.Floor(workingHours / 5.0);

            if (cupsNum >= cupsNeeded)
            {
                var extraMoney = cupsNum * 4.2 - cupsNeeded * 4.2;
                Console.WriteLine("{0:f2} extra money", extraMoney);
            }
            else
            {
                var losses = cupsNeeded * 4.2 - cupsNum * 4.2;
                Console.WriteLine("Losses: {0:f2}", losses);

            }
        }
    }
}
