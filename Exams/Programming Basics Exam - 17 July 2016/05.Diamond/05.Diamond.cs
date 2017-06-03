using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 5 * n;
            var rows = 3 * n + 2;

            var upperPartRows = n - 1;
            var lowerPartRows = rows - upperPartRows - 3;
            //FirstRow
            var leftDotsNum = n;
            var starsNum = columns - 2 * leftDotsNum;
            Console.WriteLine("{0}{1}{0}", new string('.', leftDotsNum), new string('*', starsNum));

            leftDotsNum--;
            
            //UpperPart
            var middleDotsNum = starsNum;
            for (int i = 0; i < upperPartRows; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftDotsNum), new string('.', middleDotsNum));
                leftDotsNum--;
                middleDotsNum += 2;
            }

            //MiddleRow
            Console.WriteLine("{0}", new string('*', columns));

            //LowerPart
            leftDotsNum++;
            middleDotsNum -= 2;

            for (int i = 0; i < lowerPartRows; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftDotsNum), new string('.', middleDotsNum));
                leftDotsNum++;
                middleDotsNum -= 2;
            }
            // LastRow
            starsNum = middleDotsNum + 2;
            Console.WriteLine("{0}{1}{0}", new string('.', leftDotsNum), new string('*', starsNum));

        }
    }
}
