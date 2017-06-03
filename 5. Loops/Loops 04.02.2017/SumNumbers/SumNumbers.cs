using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
