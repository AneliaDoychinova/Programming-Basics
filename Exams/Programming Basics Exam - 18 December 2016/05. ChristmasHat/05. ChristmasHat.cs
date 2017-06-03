using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 4 * n + 1;
            var rows = 2 * n + 5;
            var numberOfDots = (columns - 3)/2;

            Console.WriteLine("{0}/|\\{0}", new string('.', numberOfDots));
            Console.WriteLine("{0}\\|/{0}", new string('.', numberOfDots));
           
            
           
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', numberOfDots), new string('*', 1), new string('-', i));
                numberOfDots--;
            }

            Console.WriteLine("{0}", new string('*', columns));
            for (int i = 0; i < columns / 2; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', columns));

            
        }
    }
}
