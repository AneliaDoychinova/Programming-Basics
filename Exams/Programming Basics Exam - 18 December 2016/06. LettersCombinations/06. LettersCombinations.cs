using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var letterStart = char.Parse(Console.ReadLine());
            var letterFinish = char.Parse(Console.ReadLine());
            var letterExceptation = char.Parse(Console.ReadLine());

            var counter = 0;

            for (char i = letterStart; i <= letterFinish; i++)
            {
                for (char j = letterStart; j <= letterFinish; j++)
                {
                    for (char k = letterStart; k <= letterFinish; k++)
                    {
                        if (i != letterExceptation && j != letterExceptation && k != letterExceptation)
                        {
                            counter++;
                            Console.Write("{0}{1}{2} ", i, j, k);
                         
                        }
  
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
