using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var loadsNum = int.Parse(Console.ReadLine());

            var microbusPrice = 200;
            var truckPrice = 175;
            var trainPrice = 120;

            var totalTonage = 0.0;
            var microbus = 0;
            var truck = 0;
            var train = 0;

            for (int i = 0; i < loadsNum; i++)
            {
                var tonage = int.Parse(Console.ReadLine());
                totalTonage += tonage;

                if (tonage <= 3)
                {
                    microbus += tonage;
                }
                else if (tonage >= 4 && tonage <= 11)
                {
                    truck += tonage;
                }
                else if (tonage >= 12)
                {
                    train += tonage;
                }


            }

            var averageSum = (microbus * microbusPrice + truck * truckPrice + train * trainPrice) / totalTonage;

            var microbusPercentsTons = microbus / totalTonage * 100.0;
            var truckPercentsTons = truck / totalTonage * 100.0;
            var trainPercentsTons = train / totalTonage * 100.0;

            Console.WriteLine("{0:f2}", averageSum);
            Console.WriteLine("{0:f2}%", microbusPercentsTons);
            Console.WriteLine("{0:f2}%", truckPercentsTons);
            Console.WriteLine("{0:f2}%", trainPercentsTons);

        }
    }
}
