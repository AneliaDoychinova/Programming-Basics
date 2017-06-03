using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorLenght = double.Parse(Console.ReadLine());
            var triangleSide = double.Parse(Console.ReadLine());
            var triangleHeight = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var workmanPrice = double.Parse(Console.ReadLine());

            var areaBathroom = floorLenght * floorWidth;
            var areaTile = triangleSide * triangleHeight / 2;
            var tilesNeeded = Math.Ceiling(areaBathroom / areaTile) + 5;
            var totalPriceOfTiles = tilesNeeded * tilePrice;
            var totalPrice = totalPriceOfTiles + workmanPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine("{0:f2} lv left.", money - totalPrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", totalPrice - money);
            }
        }
    }
}
