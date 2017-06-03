using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numberCount200 = 0.0;
            var numberCount400 = 0.0;
            var numberCount600 = 0.0;
            var numberCount800 = 0.0;
            var biggerNum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    numberCount200++;
                }
                else if (number >= 200 && number < 400)
                {
                    numberCount400++;
                }
                else if (number >= 400 && number < 600)
                {
                    numberCount600++;
                }
                else if (number >= 600 && number < 800)
	            {
                    numberCount800++;
	            }
                else
                {
                    biggerNum++;
                }
            }
            var numberCount200Percent = (numberCount200 / n) * 100.0;
            var numberCount400Percent = (numberCount400 / n) * 100.0;
            var numberCount600Percent = (numberCount600 / n) * 100.0;
            var numberCount800Percent = (numberCount800 / n) * 100.0;
            var biggerNumPercent = (biggerNum / n) * 100.0;

            Console.WriteLine("{0:f2}%", numberCount200Percent);
            Console.WriteLine("{0:f2}%", numberCount400Percent);
            Console.WriteLine("{0:f2}%", numberCount600Percent);
            Console.WriteLine("{0:f2}%", numberCount800Percent);
            Console.WriteLine("{0:f2}%", biggerNumPercent);

        }
    }
}
