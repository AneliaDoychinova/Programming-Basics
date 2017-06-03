using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricePerSquareMeter = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;
            var hallway = (smallestRoom + kitchen + bathroom + secondRoom + thirdRoom) * 0.05;

            var totalArea = smallestRoom + kitchen + bathroom + secondRoom + thirdRoom + hallway;

            var totalPrice = totalArea * pricePerSquareMeter;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
