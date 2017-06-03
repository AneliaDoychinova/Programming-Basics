using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n + 1;

            //FirstRow
            var intervalNum = n + 1;
            Console.WriteLine("{0}|", new string (' ', intervalNum));

            //MiddlePart

            var middleRows = n - 1;
            intervalNum = n - 1;
            var starsNum = 1;
         
            for (int i = 0; i < middleRows; i++)
            {
                Console.WriteLine("{0}{1} | {1}", new string(' ', intervalNum), new string('*', starsNum));
                intervalNum--;
                starsNum++;
            }

            //LastRow
            starsNum = n;
            
            Console.WriteLine("{0} | {0}", new string('*', starsNum));
            

        }
    }
}
