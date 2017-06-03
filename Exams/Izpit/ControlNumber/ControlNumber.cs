using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

            var totalSum = 0;
            var currentSum = 0;
            var counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    totalSum += currentSum;
                    currentSum = i * 2 + j * 3;
                    counter++;

                    if (totalSum >= controlNum)
                    {
                        Console.WriteLine("{0} moves", counter-1);
                        Console.WriteLine("Score: {0} >= {1}", totalSum, controlNum);
                        return;
                    }
                    
                }
            }
            Console.WriteLine("{0} moves", counter);
        }
    }
}
