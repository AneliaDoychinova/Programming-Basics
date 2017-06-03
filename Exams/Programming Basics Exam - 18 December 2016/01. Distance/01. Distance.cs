using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTimeMins = int.Parse(Console.ReadLine());
            var secondTimeMins = int.Parse(Console.ReadLine());
            var thirdTimeMins = int.Parse(Console.ReadLine());

            var lenghtFirstSpeed = firstTimeMins / 60.0 * speed;
           
            var secondSpeed = speed * 1.1;
            var lenghtSecondSpeed = secondSpeed * (secondTimeMins / 60.0);

            var thirdSpeed = secondSpeed * 0.95;
            var lenghtThirdSpeed = thirdSpeed * (thirdTimeMins / 60.0);

            var totalLenght = lenghtFirstSpeed + lenghtSecondSpeed + lenghtThirdSpeed;

            Console.WriteLine("{0:f2}",totalLenght);
        }
    }
}
