using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 2 * (n - 2) + 1;
            var columns = 2 * n - 1;

            var upperRows = n - 2;
            var starsNum = n - 2;
            var dashesNum = n - 2;
            var intervalsNum = n - 2 + 1;

        

            for (int i = 1; i <= rows; i++)
            {
                if (i == upperRows + 1)
                {
                    Console.WriteLine("{0}@", new string(' ', intervalsNum));
                }
                else if (i <= upperRows)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("{0}\\ /{0}", new string('*', starsNum));
                    }
                    else
                    {
                        Console.WriteLine("{0}\\ /{0}", new string('-', dashesNum));
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("{0}/ \\{0}", new string('*', starsNum));
                    }
                    else
                    {
                        Console.WriteLine("{0}/ \\{0}", new string('-', dashesNum));
                    }
                }
            }
        }
    }
}
