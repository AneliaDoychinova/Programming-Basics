using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var firstRunner = int.Parse(Console.ReadLine());
            var secondRunner = int.Parse(Console.ReadLine());
            var thirdRunner = int.Parse(Console.ReadLine());

            var totalSeconds = firstRunner + secondRunner + thirdRunner;

            var minutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}
