using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kilometersPerMonth = double.Parse(Console.ReadLine());

            var salary = 0.0;

            if (kilometersPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = 0.75;
                }
                else if (season == "Summer")
                {
                    salary = 0.9;
                }
                else if (season == "Winter")
                {
                    salary = 1.05;
                }
               
            }
            else if (kilometersPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = 0.95;
                }
                else if (season == "Summer")
                {
                    salary = 1.1;
                }
                else if (season == "Winter")
                {
                    salary = 1.25;
                }
            }
            else if(kilometersPerMonth <= 20000)
            {
                salary = 1.45;
            }

            var totalSalary = salary * kilometersPerMonth * 4;
            totalSalary = totalSalary * 0.9;

            Console.WriteLine("{0:f2}", totalSalary);
        }
    }
}
