using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dailyProfit = double.Parse(Console.ReadLine());
            var usdToLev = double.Parse(Console.ReadLine());

            var monthSalary = workingDays * dailyProfit;
            var yearlyProfit = monthSalary * 12 + monthSalary * 2.5;
            var taxes = 0.25 * yearlyProfit;
            var realProfit = (yearlyProfit - taxes) / 365 * usdToLev;
            Console.WriteLine(Math.Round(realProfit, 2));

        }
    }
}
