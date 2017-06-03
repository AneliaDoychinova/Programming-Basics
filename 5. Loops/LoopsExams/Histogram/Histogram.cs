using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var countNum = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < countNum; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else 
                {
                    p5++;
                }
            }
            var p1Percents = p1 / countNum * 100;
            var p2Percents = p2 / countNum * 100;
            var p3Percents = p3 / countNum * 100;
            var p4Percents = p4 / countNum * 100;
            var p5Percents = p5 / countNum * 100;



            Console.WriteLine("{0:f2}%", p1Percents);
            Console.WriteLine("{0:f2}%", p2Percents);
            Console.WriteLine("{0:f2}%", p3Percents);
            Console.WriteLine("{0:f2}%", p4Percents);
            Console.WriteLine("{0:f2}%", p5Percents);

        }
    }
}
