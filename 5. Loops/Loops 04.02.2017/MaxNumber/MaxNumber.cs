using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
