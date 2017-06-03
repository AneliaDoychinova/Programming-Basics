using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 3 * n;

            var rowsUpperPart = n;
            var rowsMiddlePart = 2 * n;
            var rowsLowerPart = n / 2;

            var dotsNumLeftPart = (columns - 2) / 2;
            var intervalsNum = 0;

            //UpperPart
            for (int i = 0; i < rowsUpperPart; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsNumLeftPart), new string(' ', intervalsNum));
                dotsNumLeftPart--;
                intervalsNum += 2;
            }
            var starsNum = intervalsNum;
            dotsNumLeftPart = dotsNumLeftPart + 1;

            Console.WriteLine("{0}{1}{0}", new string ('.', dotsNumLeftPart), new string ('*', starsNum));

            //MiddlePart

            var slashes = columns - (dotsNumLeftPart * 2) - 2;
            for (int i = 0; i < rowsMiddlePart; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string ('.', dotsNumLeftPart), new string('\\',slashes));
            }

            //LowerPart
            starsNum = slashes;

            for (int i = 0; i < rowsLowerPart; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsNumLeftPart), new string('*', starsNum));

                dotsNumLeftPart--;
                starsNum += 2;
            }

        }
    }
}
