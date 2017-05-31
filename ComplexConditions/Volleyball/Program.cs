using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var games = (((48-h) * 3.0 / 4) + (2.0 / 3 * p) + h);

            if (year == "normal")
            {
                Console.WriteLine(Math.Floor(games));
            }
            else
	        {
               Console.WriteLine(Math.Floor((0.15 * games) + games));     
        	}

        }
    }
}
