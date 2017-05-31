using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var firstRectangleInside = ((x > 0 && x < 3 * h) && (y < h && y > 0));
            var firstRectangleOutside = ((x < 0 || x > 3 * h) || ( y < 0 || y > h));
            var secondRectangleInside = ((x > h && x < 2 * h) && (y < 4 * h && y > h));
            var secondRectangleOutside = (( x < h || x > 2 * h) || (y < h || y > 4 * h));
            var betweenRectangles = (x > h && x < 2 * h && y == h);

            if (firstRectangleInside || secondRectangleInside || betweenRectangles)
            {
                Console.WriteLine("inside");
            }
            else if (firstRectangleOutside && secondRectangleOutside)  
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
