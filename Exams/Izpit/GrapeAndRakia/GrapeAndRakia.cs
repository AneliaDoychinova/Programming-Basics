using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            var vineyardArea = double.Parse(Console.ReadLine());
            var kilosBySquare = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());

            var grapeKilos = vineyardArea * kilosBySquare - waste;
            var rakia = 0.45 * grapeKilos/7.5;
            var forSale = 0.55 * grapeKilos;
            var rakiaIncome = rakia * 9.8;
            var otherIncome = forSale * 1.5;

            Console.WriteLine("{0:f2}", rakiaIncome);
            Console.WriteLine("{0:f2}", otherIncome);


        }
    }
}
