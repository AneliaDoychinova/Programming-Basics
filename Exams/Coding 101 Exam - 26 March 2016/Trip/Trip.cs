using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var moneySpend = 0.0;
            var place = "";
            var holidayType = "";

            switch (season)
            {
                case "summer":
                    holidayType = "Camp";

                    if (budget <= 100)
                    {
                        place = "Bulgaria";
                        moneySpend = budget * 0.3;
                    }
                    else if (budget <= 1000)
                    {
                        place = "Balkans";
                        moneySpend = budget * 0.4;
                    }
                    else
                    {
                        place = "Europe";
                        moneySpend = budget * 0.9;
                        holidayType = "Hotel";
                    }
                    break;

                case "winter":

                    holidayType = "Hotel";

                    if (budget <= 100)
                    {
                        place = "Bulgaria";
                        moneySpend = budget * 0.7;
                    }
                    else if (budget <= 1000)
                    {
                        place = "Balkans";
                        moneySpend = budget * 0.8;
                    }
                    else
                    {
                        place = "Europe";
                        moneySpend = budget * 0.9;
                    }
                    break;

            }

            Console.WriteLine("Somewhere in {0}", place);
            Console.WriteLine("{0} - {1:f2}", holidayType, moneySpend);
        }
    }
}
