using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var vaccantDays = int.Parse(Console.ReadLine());

            var workingDays = 365 - vaccantDays;
            var timeForPlay = workingDays * 63 + vaccantDays * 127;


            if (timeForPlay > 30000)
            {
                double hours = (timeForPlay - 30000) / 60;
                double minutes = (timeForPlay - 30000) % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Truncate(hours), Math.Truncate(minutes));
            }
            else
            {
                double hours = (30000 - timeForPlay) / 60;
                double minutes = (30000 - timeForPlay) % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Truncate(hours), Math.Truncate(minutes));
            }

        }
    }
}
