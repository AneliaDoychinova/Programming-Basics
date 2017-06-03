using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

           var f0 = 1;
           var f1 = 1;
           var nextNumber = 0;

           if (n < 2)
           {
               Console.WriteLine("1");
           }
           else
           {
               for (int i = 2; i <= n; i++)
               {
                   nextNumber = f0 + f1;
                   f0 = f1;
                   f1 = nextNumber;

               }
               Console.WriteLine(nextNumber);
           }
        }
    }
}
