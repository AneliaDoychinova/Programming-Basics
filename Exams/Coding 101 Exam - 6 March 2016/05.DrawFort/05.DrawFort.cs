using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 2 * n;
            var rows = n;
            var leftColumn = n / 2;
            var numOfUnderscores = columns - (leftColumn * 2 + 4);
            var numOfIntervals = columns - 2;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', leftColumn), new string('_', numOfUnderscores));

            //midle part
            var middleRows = n - 2;

            for (int i = 0; i < middleRows - 1; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', columns - 2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', (columns - 2 - numOfUnderscores) / 2), new string('_', numOfUnderscores));
            
            numOfIntervals = numOfUnderscores;

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', leftColumn), new string(' ', numOfIntervals));
             

        }
    }
}
