using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n;
            var columns = 5 * n;

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            for (int row = 0; row < n - 2; row++)
            {
                if (row == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("*" + new string('/', (2 * n) - 2) + "*" + new string('|', n) + "*" + new string('/', (2 * n) - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('/', (2 * n) - 2) + "*" + new string(' ', n) + "*" + new string('/', (2 * n) - 2) + "*");
                }
            }

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        }
    }
}
