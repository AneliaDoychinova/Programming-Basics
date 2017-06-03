using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine(minNumber);
        }
    }
}
