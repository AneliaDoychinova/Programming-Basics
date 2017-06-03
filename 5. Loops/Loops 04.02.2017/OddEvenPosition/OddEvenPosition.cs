using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n ; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;

                    evenMax = Math.Max(evenMax, number);
                    evenMin = Math.Min(evenMin, number);

                }
                else
                {
                    oddSum += number;

                    oddMax = Math.Max(oddMax, number);
                    oddMin = Math.Min(oddMin, number);

                }
            }

            Console.WriteLine("OddSum="+oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }
            Console.WriteLine("EvenSum=" + evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }



        }
    }
}
