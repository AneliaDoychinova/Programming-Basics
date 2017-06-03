using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniorsNum = int.Parse(Console.ReadLine());
            var seniorsNum = int.Parse(Console.ReadLine());
            var traceType = Console.ReadLine();

            var juniorsFee = 0.0;
            var senirsFee = 0.0;

            switch (traceType)
            {
                case "trail":
                    juniorsFee = 5.5;
                    senirsFee = 7;
                    break;

                case "cross-country":
                    juniorsFee = 8;
                    senirsFee = 9.5;
                    
                    if (juniorsNum + seniorsNum >= 50)
                    {
                        juniorsFee = 8 * 0.75;
                        senirsFee = 9.5 * 0.75;
                    }
                    break;

                case "downhill":
                    juniorsFee = 12.25;
                    senirsFee = 13.75;
                    break;

                case "road":
                    juniorsFee = 20;
                    senirsFee = 21.5;
                    break;

            }

            var totalFee = (juniorsNum * juniorsFee + seniorsNum * senirsFee) * 0.95;

            Console.WriteLine("{0:f2}", totalFee);

        }
    }
}
