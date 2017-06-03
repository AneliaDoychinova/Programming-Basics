using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var mackerelPrice = double.Parse(Console.ReadLine());
            var spratPrice = double.Parse(Console.ReadLine());
            var beltedBonitoKg = double.Parse(Console.ReadLine());
            var scadKg = double.Parse(Console.ReadLine());
            var clamsKg = int.Parse(Console.ReadLine());

            var beltedBonitoPrice = mackerelPrice * 1.6;
            var scadPrice = spratPrice * 1.8;
            var clamsPrice = 7.5;

            var moneyNeeded = beltedBonitoKg * beltedBonitoPrice + scadKg * scadPrice + clamsKg * clamsPrice;

            Console.WriteLine("{0:f2}", moneyNeeded);

        }
    }
}
