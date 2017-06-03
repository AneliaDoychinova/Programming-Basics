using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerNum = int.Parse(Console.ReadLine());
            var secondPlayerNum = int.Parse(Console.ReadLine());
            var battlesNum = int.Parse(Console.ReadLine());

            var count = 0;
            var end = false;

            for (int i = 1; i <= firstPlayerNum; i++)
            {
                for (int j = 1; j <= secondPlayerNum; j++)
                {
                    Console.Write("({0} <-> {1}) ",i, j);
                    count++;

                    if (count >= battlesNum)
                    {
                        end = true;
                        break;
                    }

                }
                if (end)
                {
                    break;  
                }
            }
        }
    }
}
