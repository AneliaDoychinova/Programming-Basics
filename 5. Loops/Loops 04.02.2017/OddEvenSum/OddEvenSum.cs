using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var oddSum = 0;
            var evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            var difference = Math.Abs(evenSum - oddSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", difference);
            }
        }
    }
}
