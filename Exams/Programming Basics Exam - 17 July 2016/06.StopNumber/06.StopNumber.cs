using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var stopNum = int.Parse(Console.ReadLine());

            for (int i = secondNum; i >= firstNum; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopNum)
                    {
                        break;
                        
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                    

                }
            }
        }
    }
}
