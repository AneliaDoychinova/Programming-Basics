using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var moneyForDay = double.Parse(Console.ReadLine());
            var dolarForLev = double.Parse(Console.ReadLine());

            var salary = workingDays * moneyForDay;
            var bonus = salary * 2.5;
            var moneyForYear = salary * 12 + bonus;
            var taxes = moneyForYear * 0.25;

            var moneyAfterTaxes = moneyForYear - taxes;
            var moneyAfterTaxesInLeva = moneyAfterTaxes * dolarForLev;

            var dailyProfit = moneyAfterTaxesInLeva / 365;

            Console.WriteLine("{0:f2}", dailyProfit);


        }

    }
}
