using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 0;
            var columns = n;
            var middlePartRows = 0;
            var middleDashesNum = 0;

            if (n % 2 == 0)
            {
                rows = n - 1;
                middleDashesNum = 2;
            }
            else
            {
                rows = n;
                middleDashesNum = 1;
            }

            //FirstRow

            var dashesNum = (n - 1) / 2;
            var starsNum = (columns - dashesNum*2);

            if (dashesNum == 0)
            {
                starsNum = columns;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', dashesNum), new string('*', starsNum));

            //MiddlePart
            middlePartRows = rows - 2;
            dashesNum = (columns - middleDashesNum - 2) / 2;
            
            for (int i = 0; i < rows - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', dashesNum), new string('-', middleDashesNum));
                if (i < middlePartRows/2)
                {
                    dashesNum--;
                    middleDashesNum += 2;
                }
                else
                {
                    dashesNum++;
                    middleDashesNum -= 2;
                }
                
            }

            //LastRow
            if (n>2)
            {
                dashesNum = (n - 1) / 2;
            starsNum = (columns - dashesNum * 2);

            if (dashesNum == 0)
            {
                starsNum = columns;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', dashesNum), new string('*', starsNum));
            }
            
        }
    }
}
