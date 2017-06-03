using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritedMoney = double.Parse(Console.ReadLine());
            var yearToLive = int.Parse(Console.ReadLine());

            var moneyLeft = 0.0;
            var moneySpend = 0.0;
            var years = 18;

            for (int i = 1800; i <= yearToLive; i++)
            {
                
                if (i % 2 == 0)
                {
                    moneySpend += 12000;
                    moneyLeft = inheritedMoney - moneySpend;

                }
                else
                {
                    moneySpend += 12000 + 50 * years;
                    moneyLeft = inheritedMoney - moneySpend;
                }
                years++;
            }

            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(moneyLeft));
            }
        }
    }
}
