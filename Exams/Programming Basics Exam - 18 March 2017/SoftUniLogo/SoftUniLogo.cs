using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 4 * n - 2;
            var columns = 12 * n - 5;
            var hash = 1;
            var points = (columns - hash) / 2;
            var bottomRows = n;

            //Upper Part
            var upperRows = n * 2;
            for (int i = 0; i < upperRows; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.',points), new string('#', hash));
                hash += 6;
                points = (columns - hash) / 2;
            }

            //Middle Part 
            var middleRows = rows - upperRows - bottomRows;
            var leftPoints = 2;
            var rightPoints = 3;
            hash = columns - leftPoints - rightPoints - 1;

            for (int i = 0; i < middleRows; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', leftPoints), new string('#',hash), new string('.', rightPoints));

                leftPoints += 3;
                rightPoints += 3;
                hash = columns - leftPoints - rightPoints - 1;
            }

            //Bottom Part
            
   
            for (int i = 0; i < bottomRows; i++)
            {
                
                if (i == bottomRows -1)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', leftPoints), new string('#',hash), new string('.', rightPoints));
                }
                else
                {
                     Console.WriteLine("|{0}{1}{2}", new string('.', leftPoints), new string('#',hash), new string('.', rightPoints));
                }
            }
            
        }
    }
}
