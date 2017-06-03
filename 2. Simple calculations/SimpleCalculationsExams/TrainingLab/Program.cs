using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculationsExams
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var rows = (h * 100) / 120;
            var desks = ((w * 100) - 100) / 70;

            var seats = (Math.Truncate(rows) * Math.Truncate(desks)) - 3;
            Console.WriteLine(seats);

        }
    }
}
