using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n * 2 - 1;
            var columns = n * 2 - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                Console.WriteLine(magicString(" *", row - 1));
            }
            //Да се довърши долната част
            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine(magicString(" *", i));
                Console.Write(new string(' ', i) + "*");
                Console.WriteLine(magicString(" *", i - 1));

            }
        }
        public static string magicString(string text, int repeatCount)
        {
            string outputText = "";
            for (int i = 0; i < repeatCount; i++)
            {
                outputText = outputText + text;
            }
            return outputText;
        }

    }
}
