using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var totalPeople = int.Parse(Console.ReadLine());

            var transportMoney = 0.0;
            var categoryVIP = 499.99;
            var categoryNormal = 249.99;

            if (totalPeople <=4)
            {
                transportMoney = 0.75 * budget;
            }
            else if (totalPeople <= 9)
            {
                transportMoney = 0.6 * budget;
            }
            else if (totalPeople <= 24)
            {
                transportMoney = 0.5 * budget;
            }
            else if (totalPeople <= 49)
            {
                transportMoney = 0.4 * budget;
            }
            else if (totalPeople >= 50)
            {
                transportMoney = 0.25 * budget;
            }

            var moneyLeft = budget - transportMoney;
            var moneyNeeded = 0.0;


            if (category == "VIP")
            {
                moneyNeeded = totalPeople * categoryVIP;
            }
            else
            {
                moneyNeeded = totalPeople * categoryNormal;
            }

            if (moneyLeft >= moneyNeeded)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - moneyNeeded);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded - moneyLeft);
            }

        }
    }
}
