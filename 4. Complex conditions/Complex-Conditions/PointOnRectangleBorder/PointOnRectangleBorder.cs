using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var isPointOnLeftBorder = x1 == x && y1 <= y && y2 >= y;
            var isPointOnRightBorder = x2 == x && y1 <= y && y2 >= y;
            var isPointOnUpperBorder = y1 == y && x1 <= x && x2 >= x;
            var isPointOnBottomBorder = y2 == y && x1 <= x && x2 >= x;

            var isPointOnAnyBorder = isPointOnBottomBorder || isPointOnLeftBorder || isPointOnRightBorder || isPointOnUpperBorder;

            if (isPointOnAnyBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }


        }
    }
}
