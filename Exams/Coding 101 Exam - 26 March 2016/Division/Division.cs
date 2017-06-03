using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var numberDividedByTwo = 0.0;
            var numberDividedByThree = 0.0;
            var numberDividedByFour = 0.0;


            for (int i = 0; i < numbersCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    numberDividedByTwo++;
                }

                if (currentNumber % 3 == 0)
                {
                    numberDividedByThree++;
                }

                if (currentNumber % 4 == 0)
                {
                    numberDividedByFour++;
                }

            }

            var percentsNumbersDividedByTwo = numberDividedByTwo / numbersCount * 100;
            var percentsNumbersDividedByThree = numberDividedByThree / numbersCount * 100;
            var percentsNumbersDividedByFour = numberDividedByFour / numbersCount * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%"
                , percentsNumbersDividedByTwo, percentsNumbersDividedByThree, percentsNumbersDividedByFour);
        }
    }
}
