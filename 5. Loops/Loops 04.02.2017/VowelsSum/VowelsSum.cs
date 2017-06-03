using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    sum += 1;
                }
                else if (word[i] == 'e')
                {
                    sum += 2;
                }
                else if (word[i] == 'i')
                {
                    sum += 3;
                }
                else if (word[i] == 'o')
                {
                    sum += 4;
                }
                else if (word[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
