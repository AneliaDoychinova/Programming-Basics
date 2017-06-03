using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var IsDayOfWeekend = dayOfWeek == "saturday" || dayOfWeek == "sunday";
            var isDayOfWeek = dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday";
            var price = 0.0;

            if (isDayOfWeek)
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5;
                        break;

                    case "apple":
                        price = 1.2;
                        break;

                    case "orange":
                        price = 0.85;
                        break;

                    case "grapefruit":
                        price = 1.45;
                        break;

                    case "kiwi":
                        price = 2.7;
                        break;

                    case "pineapple":
                        price = 5.5;
                        break;

                    case "grapes":
                        price = 3.85;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("{0:f2}", quantity * price);
            }
            else if(IsDayOfWeekend)
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7;
                        break;

                    case "apple":
                        price = 1.25;
                        break;

                    case "orange":
                        price = 0.9;
                        break;

                    case "grapefruit":
                        price = 1.6;
                        break;

                    case "kiwi":
                        price = 3;
                        break;

                    case "pineapple":
                        price = 5.6;
                        break;

                    case "grapes":
                        price = 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
                Console.WriteLine("{0:f2}", quantity * price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
