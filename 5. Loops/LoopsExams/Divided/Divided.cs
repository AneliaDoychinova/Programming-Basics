using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divided
{
    class Divided
    {
        static void Main(string[] args)
        {
            var countNum = int.Parse(Console.ReadLine());

            var numsDividedByTwo = 0.0;
            var numsDividedByThree = 0.0;
            var numsDividedByFour = 0.0;

            for (int i = 0; i < countNum; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    numsDividedByTwo++;

                }
                if (num % 3 == 0)
                {
                    numsDividedByThree++;
                }
                if (num % 4 == 0)
                {
                    numsDividedByFour++; 
                }
            }

            var numsDividedByTwoPercents = numsDividedByTwo / countNum * 100;
            var numsDividedByThreePercents = numsDividedByThree / countNum * 100;
            var numsDividedByFourPercents = numsDividedByFour / countNum * 100;

            Console.WriteLine("{0:f2}%", numsDividedByTwoPercents);
            Console.WriteLine("{0:f2}%", numsDividedByThreePercents);
            Console.WriteLine("{0:f2}%", numsDividedByFourPercents);
        }
    }
}
