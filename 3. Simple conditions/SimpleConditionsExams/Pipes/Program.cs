using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var liters = p1 * h + p2 * h;

            if (liters <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(liters / v * 100), Math.Truncate(p1 * h / liters * 100), Math.Truncate(p2 * h / liters * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, liters - v);
            }

        }
    }
}
