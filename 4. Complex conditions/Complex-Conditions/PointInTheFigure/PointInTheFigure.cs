using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var upperRectangleX1 = h;
            var upperRectangleY1 = 4 * h;
            var upperRectangleX2 = 2 * h;
            var upperRectangleY2 = h;

            var lowerRectangleX1 = 0;
            var lowerRectangleY1 = 0;
            var lowerRectangleX2 = 3 * h;
            var lowerRectangleY2 = h;

            var isPointOutOfUpperRectangle = x < upperRectangleX1 || x > upperRectangleX2 || y < upperRectangleY2 || y > upperRectangleY1;
            var isPointOutOfLowerRectangle = x < lowerRectangleX1 || x > lowerRectangleX2 || y < lowerRectangleY1 || y > lowerRectangleY2;
           
            var isPointOnBorderBetweenRectangles = (y == lowerRectangleY2) && (x > upperRectangleX1 && x < upperRectangleX2);
            var isPointInUpperRectangle = x > upperRectangleX1 && x < upperRectangleX2 && y > upperRectangleY2 && y < upperRectangleY1;
            var isPointInLowerRectangle = x > lowerRectangleX1 && x < lowerRectangleX2 && y > lowerRectangleY1 && y < lowerRectangleY2;


            if (isPointOutOfLowerRectangle && isPointOutOfUpperRectangle)
            {
                Console.WriteLine("outside");
            }
            else if (isPointOnBorderBetweenRectangles || isPointInLowerRectangle || isPointInUpperRectangle)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }



        }
    }
}
