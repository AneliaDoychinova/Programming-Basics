using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            var maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }

            if ((sum - maxNum) == maxNum)
            {
                Console.WriteLine("Yes Sum = " + maxNum);
            }
            else
            {
                var diff = Math.Abs((sum - maxNum) - maxNum);
                Console.WriteLine("No Diff = " + diff);
            }
        }
    }
}
