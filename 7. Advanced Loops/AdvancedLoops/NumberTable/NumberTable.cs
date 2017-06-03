using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (var tableRow = 1;
                tableRow <= n;
                tableRow++)
            {
                var numberToPrint = tableRow;
                var isMaxNumberPrinted = false;
                for (var tableColumn = 1;
                    tableColumn <= n;
                    tableColumn++)
                {
                    Console.Write("{0} ", numberToPrint);
                    if (numberToPrint == n)
                    {
                        isMaxNumberPrinted = true;
                    }
                    if (isMaxNumberPrinted)
                    {
                        numberToPrint--;
                    }
                    else
                    {
                        numberToPrint++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
