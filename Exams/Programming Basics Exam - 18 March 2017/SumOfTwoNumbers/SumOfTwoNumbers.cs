using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var combinationNum = 0;
            var total = 0;
            var isCombinationFound = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combinationNum++;
                    total = i + j;

                    if (total == magicNum)
                    {
                        isCombinationFound = true;
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinationNum, i ,j, magicNum);
                        return;
                    }
                }
          
            }
            if (!isCombinationFound)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationNum, magicNum);
            }
        }
    }
}
