using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var peopleNum = int.Parse(Console.ReadLine());

            var transport = 0.0;

            if (peopleNum < 5)
            {
                transport = 0.75 * budget;
            }
            else if (peopleNum < 10 )
            {
                transport = 0.60 * budget;
            }
            else if (peopleNum < 25)
            {
                transport = 0.50 * budget;
            }
            else if (peopleNum < 50)
            {
                transport = 0.40 * budget;
            }
            else if (peopleNum >= 50)
            {
                transport = 0.25 * budget;
            }

            var moneyLeft = budget - transport;

            if (category == "VIP")
            {
                var result = 499.99 * peopleNum;
                if (moneyLeft > result)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - result);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", result - moneyLeft);
                }
            }
            else if (category == "Normal")
            {
                var result = 249.99 * peopleNum;
                if (moneyLeft > result)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - result);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", result - moneyLeft);
                }

            }


        }
    }
}
