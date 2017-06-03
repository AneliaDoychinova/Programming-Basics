using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 2 * n;
            var rows = n;
            var columnsMiddleWidth = n / 2;
            var midlleRows = n - 2;
            var underscoreNums = (2 * n) - ((n / 2) * 2 + 4);
            var intervalNums = (2 * n) - ((n / 2) * 2 + 4);

            Console.Write("/" + new string('^', columnsMiddleWidth) + @"\");
            if (((n / 2 + 2) * 2) < (2 * n))
            {
                Console.Write(new string('_', underscoreNums));
            }
            Console.WriteLine("/" + new string('^', columnsMiddleWidth) + @"\");
            if (n<5)
            {

                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine("|" + new string(' ', columns - 2) + "|");
                }
            }
            else
            {
                for (int i = 1; i <= n - 3; i++)
                {
                    Console.WriteLine("|" + new string(' ', columns - 2) + "|");
                }
            }
            if (((n / 2 + 2) * 2) < (2 * n))
            {
                Console.WriteLine("|" + new string(' ', (columns - 2 - underscoreNums) / 2) + new string('_', underscoreNums) + new string(' ', (columns - 2 - underscoreNums) / 2) + "|");
            }
            Console.WriteLine(@"\" + new string('_', columnsMiddleWidth) + "/" + new string(' ', intervalNums) + @"\" + new string('_', columnsMiddleWidth) + "/");
            



        }
    }
}
