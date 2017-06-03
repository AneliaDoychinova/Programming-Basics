using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 5 * n;
            var upperPartRows = n;
            var middlePartRows = n / 2;
            var lowerPartRows = n / 2 - 1;

            //UpperPart

            var leftUnderscores = n * 3;
            var rightUnderscores = columns - leftUnderscores - 2;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}*{1}*{2}", new string('-', leftUnderscores), new string('-', i), new string('-', rightUnderscores));

                rightUnderscores--;
            }

            //MiddlePart
            var middleUnderscores = n - 1;
            rightUnderscores += 1;
            for (int i = 0; i < middlePartRows; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftUnderscores), new string('-', middleUnderscores), new string('-', rightUnderscores));
            }

            //LowerPart
            
            for (int i = 0; i < lowerPartRows; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftUnderscores), new string('-', middleUnderscores), new string('-', rightUnderscores));
                leftUnderscores--;
                rightUnderscores--;
                middleUnderscores += 2;
                                
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', leftUnderscores), new string('*', middleUnderscores), new string('-', rightUnderscores));
        }
    }
}
