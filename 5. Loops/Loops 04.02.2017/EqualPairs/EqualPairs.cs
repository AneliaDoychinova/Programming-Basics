using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var currentPairSum = 0;
            var lastPairSum = 0;
            var difference = 0;
            var maxDiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
             
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                currentPairSum = num1 + num2;

                

                if (i != 0)
                {
                    difference = Math.Abs(currentPairSum - lastPairSum);
                    if (difference > maxDiff)
                {
                    maxDiff = difference;
                }
                }

                lastPairSum = currentPairSum;
            }
            if (difference == 0 || n == 1)
            {
                Console.WriteLine("Yes, value=" +currentPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" +Math.Abs(maxDiff));
            }
        }
    }
}
