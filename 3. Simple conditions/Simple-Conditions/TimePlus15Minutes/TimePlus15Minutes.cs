using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var minutesPlus15 = minutes + 15;

            if (minutesPlus15 > 59)
            {
                hour++;
                minutesPlus15 = minutesPlus15 - 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine("{0}:{1:00}", hour, minutesPlus15);
        }
    }
}
