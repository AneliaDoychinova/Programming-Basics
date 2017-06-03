using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var currentNumberToPrint = 1;
            var numbersToPrintCount = 1;
            while (currentNumberToPrint <= n)
            {
                for (var i = 0;
                    i < numbersToPrintCount;
                    i++)
                {
                    Console.Write("{0} ",
                        currentNumberToPrint);
                    currentNumberToPrint++;
                    if (currentNumberToPrint > n)
                    {
                        break;
                    }

                }
                numbersToPrintCount++;
                Console.WriteLine();
            }
        }
    }
}
