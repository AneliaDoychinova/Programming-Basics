using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var columns = 2 * n + 3;
            var upperPartRows = n;
            var lowerPartRows = n;
            var middlePartRows = n / 3;

            //upperPart
            var starsNum = 1;
            var dashNum= columns - 4;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', starsNum), new string('-',dashNum));

                starsNum++;
                dashNum -= 2;
            }

            //middlePart
            var outterStars = n / 2;
            var innerStars = n;

            for (int i = 0; i < middlePartRows; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', outterStars), new string('*', innerStars));
                
                outterStars++;
                innerStars -= 2;

            }

            //lowerPart
            dashNum = 1;
            starsNum = columns - 4;

            for (int i = 0; i < lowerPartRows; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dashNum), new string('*', starsNum));

                dashNum++;
                starsNum -= 2;
            }


        }
    }
}
