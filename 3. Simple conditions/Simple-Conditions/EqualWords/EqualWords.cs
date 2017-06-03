using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine().ToLower();
            var secondWord = Console.ReadLine().ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
