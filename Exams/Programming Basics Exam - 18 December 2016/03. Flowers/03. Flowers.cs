using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrysanthemums = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();

            var chrysanthemumsPrice = 0.0;
            var rosesPrice = 0.0;
            var tulipsPrice = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumsPrice = 2.00;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.5;
                    tulipsPrice = 4.15;
                    break;

            }
            var totalPrice = roses * rosesPrice + chrysanthemums * chrysanthemumsPrice + tulips * tulipsPrice;
            if (holiday == "Y")
            {
                totalPrice *= 1.15;
            }
            if (tulips > 7 && season == "Spring")
            {
                totalPrice *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {
                totalPrice *= 0.9;
            }
            if ((chrysanthemums + tulips + roses)>20)
            {
                totalPrice *= 0.8;
            }
            totalPrice = totalPrice + 2;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
