using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuans = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var bitcoinsToLev = bitcoins * 1168;
            var yuansToLev = (yuans * 0.15) * 1.76;
            var euro = (bitcoinsToLev + yuansToLev) / 1.95;

            var num = euro - (comission * 0.01 * euro);
            Console.WriteLine(num);
         }
    }
}
