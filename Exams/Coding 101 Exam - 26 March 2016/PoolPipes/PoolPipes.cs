using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var firstPipeFlow = int.Parse(Console.ReadLine());
            var secondPipeFlow = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var firstPipeFilled = firstPipeFlow * hours;
            var secondPipeFilled = secondPipeFlow * hours;

            var poolFilled = firstPipeFilled + secondPipeFilled;
            var poolFilledPercents =Math.Truncate(poolFilled / poolVolume * 100);
            var firstPipePercents = Math.Truncate(firstPipeFilled / poolFilled * 100);
            var secondPipePercents = Math.Truncate(secondPipeFilled / poolFilled * 100);


            if (poolFilled <= poolVolume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                                , poolFilledPercents, firstPipePercents, secondPipePercents);

            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, poolFilled - poolVolume);
            }

        }
    }
}
