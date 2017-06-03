using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var firstDigit = number / 100;
            var secondNum = number - firstDigit * 100;
            var secondDigit = secondNum / 10 ;
            var thirdDigit = secondNum - secondDigit * 10;

            var rows = firstDigit + secondDigit;
            var columns = firstDigit + thirdDigit;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (number % 5 == 0)
                    {
                        number = number - firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number = number - secondDigit;

                    }
                    else
                    {
                        number = number + thirdDigit;
                    }

                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
