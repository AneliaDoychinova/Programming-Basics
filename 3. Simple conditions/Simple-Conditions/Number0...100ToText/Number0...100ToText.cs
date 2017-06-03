using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0._._._100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var firstWord = "";
            var secondWord = "";

            if (num == 0)
            {
                firstWord = "zero";
            }
            else if (num == 1)
            {
                firstWord = "one";
            }
            else if (num == 2)
            {
                firstWord = "two";
            }
            else if (num == 3)
            {
                firstWord = "three";
            }
            else if (num == 4)
            {
                firstWord = "four";
            }
            else if (num == 5)
            {
                firstWord = "five";
            }
            else if (num == 6)
            {
                firstWord = "six";
            }
            else if (num == 7)
            {
                firstWord = "seven";
            }
            else if (num == 8)
            {
                firstWord = "eight";
            }
            else if (num == 9)
            {
                firstWord = "nine";
            }
            else if (num == 10)
            {
                firstWord = "ten";
            }
            else if (num == 11)
            {
                firstWord = "eleven";
            }
            else if (num == 12)
            {
                firstWord = "twelve";
            }
            else if (num == 13)
            {
                firstWord = "thirteen";
            }
            else if (num == 14)
            {
                firstWord = "fourteen";
            }
            else if (num == 15)
            {
                firstWord = "fifteen";
            }
            else if (num == 16)
            {
                firstWord = "sixteen";
            }
            else if (num == 17)
            {
                firstWord = "seventeen";
            }
            else if (num == 18)
            {
                firstWord = "eighteen";
            }
            else if (num == 19)
            {
                firstWord = "nineteen";
            }
            if (num / 10 > 1 && num <= 100)
            {


                if (num % 10 == 1)
                {
                    secondWord = " one";
                }
                else if (num % 10 == 2)
                {
                    secondWord = " two";
                }
                else if (num % 10 == 3)
                {
                    secondWord = " three";
                }
                else if (num % 10 == 4)
                {
                    secondWord = " four";
                }
                else if (num % 10 == 5)
                {
                    secondWord = " five";
                }
                else if (num % 10 == 6)
                {
                    secondWord = " six";
                }
                else if (num % 10 == 7)
                {
                    secondWord = " seven";
                }
                else if (num % 10 == 8)
                {
                    secondWord = " eight";
                }
                else if (num % 10 == 9)
                {
                    secondWord = " nine";
                }
            }
           
            if (num / 10 == 2)
            {
                firstWord = "twenty";
            }
            else if (num / 10 == 3)
            {
                firstWord = "thirty";
            }
            else if (num / 10 == 4)
            {
                firstWord = "fourty";
            }
            else if (num / 10 == 5)
            {
                firstWord = "fifty";
            }
            else if (num / 10 == 6)
            {
                firstWord = "sixty";
            }
            else if (num / 10 == 7)
            {
                firstWord = "seventy";
            }
            else if (num / 10 == 8)
            {
                firstWord = "eighty";
            }
            else if (num / 10 == 9)
            {
                firstWord = "ninety";
            }
            else if (num == 100)
            {
                firstWord = "one hundred";
            }
            
            if (num < 0 || num > 100)
            {
                firstWord = "invalid";
                secondWord = " number";
            }
           



            Console.WriteLine("{0}{1}", firstWord, secondWord);
        }
    }
}
