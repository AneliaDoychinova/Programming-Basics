using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var figureHeight = n;
            var numOfDashes = n - 2;
            var numOfmiddlerows = n - 2;
            var numOfColumns = 2 * n - 1;

            Console.Write("+");
            for (int i = 1; i <= numOfDashes; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 1; i <= numOfmiddlerows; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= numOfDashes; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");

            }
            Console.Write("+");
            for (int i = 1; i <= numOfDashes; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}
