using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            var difference = Math.Abs(leftSum - rightSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
