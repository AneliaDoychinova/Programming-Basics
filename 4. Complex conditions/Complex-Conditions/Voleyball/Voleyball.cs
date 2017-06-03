using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class Voleyball
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine();
            var holidaysNumber = int.Parse(Console.ReadLine());
            var weekendNumHomeTown = int.Parse(Console.ReadLine());

            var weekendNum = 48;
            var weekendNumInSofia = weekendNum - weekendNumHomeTown;
            var playingSaturdays = weekendNumInSofia * 3 / 4.0;
            var playingDaysHomeTown = weekendNumHomeTown;
            var playingDaysHolidays = holidaysNumber * 2 / 3.0;

            var totalPlayingDays = playingSaturdays + playingDaysHomeTown + playingDaysHolidays;

            if (typeOfYear == "leap")
            {
                totalPlayingDays = totalPlayingDays * 1.15;
            }

            Console.WriteLine(Math.Floor(totalPlayingDays));


        }
    }
}
