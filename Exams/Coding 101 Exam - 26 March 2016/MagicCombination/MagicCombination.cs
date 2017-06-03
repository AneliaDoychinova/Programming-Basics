using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            var magicNumber = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                var currentNum = i;
                var firstDigit = currentNum % 10;
                currentNum = currentNum / 10;
                var secondDigit = currentNum % 10;
                currentNum = currentNum / 10;
                var thirdDigit = currentNum % 10;
                currentNum = currentNum / 10;
                var forthDigit = currentNum % 10;
                currentNum = currentNum / 10;
                var fifthDigit = currentNum % 10;
                currentNum = currentNum / 10;
                var sixthDigit = currentNum % 10;
                currentNum = currentNum / 10;

                if (firstDigit * secondDigit * thirdDigit * forthDigit * fifthDigit * sixthDigit == magicNumber)
                {
                    Console.Write("{0} ",i);
                }

            }
        }
    }
}
