using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            Console.WriteLine(num);

            for (int i = 1; i <= n; i++)
            {
                num = num * 2;
                if (i % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
