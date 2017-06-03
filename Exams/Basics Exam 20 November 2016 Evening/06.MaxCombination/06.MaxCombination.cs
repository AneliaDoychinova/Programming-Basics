using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var combinationNum = int.Parse(Console.ReadLine());

            var count = 0;
            var maxCombination = false;

            for (int i = firstNum; i <= secondNum;i++)
            {
                for (int j = firstNum; j <= secondNum ; j++)
                {
                    Console.Write("<{0}-{1}>", i ,j);
                    count++;
                    if (count >= combinationNum)
                    {
                        maxCombination = true;
                        break;
                    }
                }
                if (maxCombination)
                {
                    break;
                }
            }
        }
    }
}
