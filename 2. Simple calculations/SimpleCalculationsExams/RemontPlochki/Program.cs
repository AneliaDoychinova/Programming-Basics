using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontPlochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());

            var areaSum = n * n;
            var benchArea = m * o;
            var tileArea = w * l;
            var tileNum = (areaSum - benchArea) / tileArea;
            var min = tileNum * 0.2;
            Console.WriteLine(tileNum);
            Console.WriteLine(min);


        }
    }
}
