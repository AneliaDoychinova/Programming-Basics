using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Pow(n, 0.5); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;

                    }

                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

             
           
        }
    }
}
