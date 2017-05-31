using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var seats = int.Parse(Console.ReadLine());

            if (projection == "Premiere")
            {
                Console.WriteLine("{0:f2}", rows * seats * 12 + " leva");
            }
            else if (projection == "Normal")
            {
                Console.WriteLine("{0:f2}", rows * seats * 7.5 + " leva");
            }
            else if (projection == "Discount")
            {
                Console.WriteLine("{0:f2}", rows * seats * 5 + " leva");
            }
        }
    }
}
