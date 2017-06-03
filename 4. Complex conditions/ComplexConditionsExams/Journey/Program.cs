using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var money = 0.0;
            string destination = "";
            string typeOfHoliday = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    typeOfHoliday = "Camp";
                    money = 0.3 * budget;
                }
                else if (season == "winter")
                {
                    typeOfHoliday = "Hotel";
                    money = 0.7 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                   typeOfHoliday = "Camp";
                    money = 0.4 * budget;
                }
                else if (season == "winter")
                {
                   typeOfHoliday = "Hotel";
                    money = 0.8 * budget;
                }
            }
            else
            {
                
                destination = "Europe";
                typeOfHoliday = "Hotel";
                money = 0.9 * budget;
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", typeOfHoliday, money);
           

        }
    }
}
