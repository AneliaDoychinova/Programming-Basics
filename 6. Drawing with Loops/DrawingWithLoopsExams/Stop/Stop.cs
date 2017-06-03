using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 2 * n + 2;
            var underscoreNums = 2 * n + 1;
            var pointsNums = n + 1;
            var middleRow = 4 * n + 3;
            var midlleRowUnderscoreNums = (middleRow - 9) / 2;

            Console.WriteLine(new string('.', pointsNums) + new string('_', underscoreNums) + new string('.', pointsNums));
            underscoreNums = underscoreNums - 2;
            pointsNums--;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', pointsNums) + "//" + new string('_', underscoreNums) + @"\\" + new string('.', pointsNums));
                pointsNums--;
                underscoreNums = underscoreNums + 2;
            }
            Console.WriteLine("//" + new string('_', midlleRowUnderscoreNums) + "STOP!" + new string('_', midlleRowUnderscoreNums) + @"\\");
          
            for (int i = 0; i < n; i++)
            {
              
                Console.WriteLine(new string('.', i) + @"\\" + new string('_', underscoreNums) + "//" + new string('.', i));
                underscoreNums = underscoreNums - 2;
            }


        }
    }
}
