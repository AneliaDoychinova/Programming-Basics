using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 2 * n - 1;
            var rows = 2 * (n - 2) + 1;
            var leftSide = n - 1;
            var numOfStars = n - 2;
            var numOfDashes = n - 2;
            var numOfIntervalsMiddle = n - 1;

            for (int i = 1; i <= n - 2; i++)
            {
                
                if (i % 2 == 0)
	            {
		        Console.Write(new string('-', numOfDashes));
                Console.Write(@"\ /");
                Console.WriteLine(new string('-', numOfDashes));
	            }
                else
	            {
                Console.Write(new string('*', numOfStars));
                Console.Write(@"\ /");
                Console.WriteLine(new string('*', numOfStars));
	            }

            }
            Console.WriteLine(new string(' ', numOfIntervalsMiddle) + "@");

            for (int i = 1; i <= n - 2; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(new string('-', numOfDashes));
                    Console.Write(@"/ \");
                    Console.WriteLine(new string('-', numOfDashes));
                }
                else
                {
                    Console.Write(new string('*', numOfStars));
                    Console.Write(@"/ \");
                    Console.WriteLine(new string('*', numOfStars));
                }

            }

        }
    }
}
