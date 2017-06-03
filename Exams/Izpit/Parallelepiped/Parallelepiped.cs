using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 4 * n + 4;
            var columns = 3 * n + 1;

            var approx = n - 2;
            var dots = columns - approx - 2;
            //First Row
            Console.WriteLine("+{0}+{1}", new string('~', approx), new string('.', dots));

            //Upper Part
            var upperRows = 2 * n + 1;
            dots = 2 * n;

            for (int i = 0; i < upperRows; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', approx), new string('.', dots));
                dots--;
            }

            //Bottom Part

            var bottomRows = upperRows;
            dots = 2 * n;
            for (int i = 0; i < bottomRows; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', dots), new string('~', approx));
                dots--;
            }

            //Last Row
            dots = columns - approx - 2;
            Console.WriteLine("{1}+{0}+", new string('~', approx), new string('.', dots));

        }
    }
}
