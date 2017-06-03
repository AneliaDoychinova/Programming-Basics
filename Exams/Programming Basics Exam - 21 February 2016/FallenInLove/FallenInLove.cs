using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 3 * n + 1;
            var columns = n * 4 + 6;

            //UpperPart
            var upperRows = n;
            var leftDotsNum = 2 * n;
            var middleDotsNum = 0;
            var leavesNum = 0;

            for (int i = 0; i < n; i++)
			{
			 Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",new string('~', leavesNum),new string('.', leftDotsNum),new string('.', middleDotsNum));
                leavesNum++;
                middleDotsNum+= 2;
                leftDotsNum -= 2;
			}

            //MiddlePart
            leftDotsNum++;
            var middleRows = n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', leftDotsNum), new string('~', leavesNum), new string('.', middleDotsNum));

                leftDotsNum += 2;
                leavesNum--;
                middleDotsNum -= 2;
            }

            //LowerPart

            Console.WriteLine("{0}####{0}", new string('.', leftDotsNum));
            leftDotsNum++;

            var lowerRows = n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', leftDotsNum));
            }
            

        }
    }
}
