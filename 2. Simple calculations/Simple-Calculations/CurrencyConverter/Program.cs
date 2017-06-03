using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var enterCurrency = Console.ReadLine();
            var exitCurrency = Console.ReadLine();

            var exitSum = 0.0;

            if (enterCurrency == "BGN" && exitCurrency == "USD")
            {
                exitSum = sum / 1.79549;
            }
            else if (enterCurrency == "BGN" && exitCurrency == "EUR")
            {
                exitSum = sum / 1.95583;
            }
            else if (enterCurrency == "BGN" && exitCurrency == "GBP")
            {
                exitSum = sum / 2.53405;
            }
            else if (enterCurrency == "USD" && exitCurrency == "BGN")
            {
                exitSum = sum * 1.79549;
            }
            else if (enterCurrency == "USD" && exitCurrency == "EUR")
            {
                exitSum = sum * 1.79549 / 1.95583;
            }
            else if (enterCurrency == "USD" && exitCurrency == "GBP")
            {
                exitSum = sum * 1.79549 / 2.53405;
            }
            else if (enterCurrency == "EUR" && exitCurrency == "BGN")
            {
                exitSum = sum * 1.95583;
            }
            else if (enterCurrency == "EUR" && exitCurrency == "USD")
            {
                exitSum = sum * 1.95583 / 1.79549;
            }
            else if (enterCurrency == "EUR" && exitCurrency == "GBP")
            {
                exitSum = sum * 1.95583 / 2.53405;
            }
            else if (enterCurrency == "GBP" && exitCurrency == "BGN")
            {
                exitSum = sum * 2.53405;
            }
            else if (enterCurrency == "GBP" && exitCurrency == "USD")
            {
                exitSum = sum * 2.53405 / 1.79549;
            }
            else if (enterCurrency == "GBP" && exitCurrency == "EUR")
            {
                exitSum = sum * 2.53405 / 1.95583;
            }


            Console.WriteLine("{0} {1}", Math.Round(exitSum, 2), exitCurrency);
        
        }
    }
}
