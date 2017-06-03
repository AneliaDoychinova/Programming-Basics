using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class HourGlass
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 2 * n + 1;
            var columns = 2 * n + 1;

            Console.WriteLine("{0}", new string('*', columns));
            Console.WriteLine(".*{0}*.", new string(' ', columns - 4));

            //Middle Part
            var middleRows = n - 2;
            var points = 2;
            var maimunka = columns - points * 2 - 2;
            for (int i = 0; i < middleRows; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', points), new string('@', maimunka));
                points++;
                maimunka -= 2;
            }

            //MiddleRow
            points = (columns - 1) / 2;
            Console.WriteLine("{0}*{0}", new string('.', points));

            //BottomPart 
            points = n - 1;

            for (int i = 0; i < n -2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', points), new string(' ',i));
                points--;
            }

            Console.WriteLine(".*{0}*.", new string('@', columns - 4));
            Console.WriteLine("{0}", new string('*', columns));
        }
    }
}
