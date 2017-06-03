using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class SmartLili
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceWashingMachine = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());

            var moneyOddBirthdays = 0.0;
            var moneyEvenBirthdays = 0.0;
            var money = 0.0;
            var moneyPlus10 = 10;
            var numEvenbirthdays = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    moneyOddBirthdays = moneyOddBirthdays + priceToy;
                }
                else
                {
                    moneyEvenBirthdays = moneyEvenBirthdays + moneyPlus10;
                    moneyPlus10 = moneyPlus10 + 10;
                    numEvenbirthdays++;
                    
                }
              
            }
            moneyEvenBirthdays = moneyEvenBirthdays - numEvenbirthdays;
            money = moneyOddBirthdays + moneyEvenBirthdays;


            if (money >= priceWashingMachine)
            {
                var moneyLeft = money - priceWashingMachine;
                Console.WriteLine("Yes! {0:f2}", moneyLeft);
            }
            else
            {
                var moneyNeeded = priceWashingMachine - money;
                Console.WriteLine("No! {0:f2}", moneyNeeded);
            }
        }
    }
}
