using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___19_March_2017___Mor
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var frontWall = Math.Pow(x,2);
            var rearWall = Math.Pow(x, 2) - (1.2 * 2);
            var sideWall = (x * y) - Math.Pow(1.5, 2);
            var roof = 2 * (x * y) + 2 * (x * h / 2);

            var greenPaint = (frontWall + rearWall + 2 * sideWall) / 3.4;
            var redPaint = roof / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
           
        }
    }
}
