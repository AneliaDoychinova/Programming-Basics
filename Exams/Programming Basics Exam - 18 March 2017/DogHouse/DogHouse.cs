using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___18_March_2017
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            var houseLenght = double.Parse(Console.ReadLine());
            var houseHeight = double.Parse(Console.ReadLine());

            var leftWallArea = houseLenght * houseLenght / 2;
            var rightWallArea = leftWallArea;
            var rearWallArea = Math.Pow(houseLenght/2, 2) + ((houseLenght / 2 * (houseHeight - houseLenght / 2)) / 2);
            var frontWallArea = rearWallArea - (Math.Pow(houseLenght / 5, 2));
            var roofArea = 2.0 * (houseLenght * houseLenght / 2);

            var greenPaint = (leftWallArea + rightWallArea + rearWallArea + frontWallArea) / 3;
            var redPaint = roofArea / 5;

            Console.WriteLine("{0:f2}",greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
