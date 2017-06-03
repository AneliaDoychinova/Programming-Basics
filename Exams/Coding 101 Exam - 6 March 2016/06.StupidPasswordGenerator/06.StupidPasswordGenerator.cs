using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numLetter = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    for (char k = 'a'; k < 'a'+numLetter; k++)
                    {
                        for (char l = 'a'; l < 'a' + numLetter; l++)
                        {
                            for (int m = 1; m <= number; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, k, l, m);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
