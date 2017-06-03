using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n;

            //UpperPart

            var upperPartRows = (n + 1) / 2;
            var starsNum = 2;
            var underscoresNum = 0;

            if (n % 2 == 0 && n != 2)
            {
                starsNum = 2;
              
            }
            else if (n % 2 == 1 && n != 2)
            {
                starsNum = 1;
            
            }
            underscoresNum = (n - starsNum)/2;
            
            for (int i = 0; i < upperPartRows; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('-', underscoresNum), new string('*', starsNum));

                starsNum += 2;
                underscoresNum -= 1;

            }
            
            //LowerPart

            var lowerPartRows = n / 2 - 1;
            starsNum = n - 2;

            for (int i = 0; i <= lowerPartRows; i++)
            {
                Console.WriteLine("|{0}|", new string('*', starsNum));
            }
        }
    }
}
