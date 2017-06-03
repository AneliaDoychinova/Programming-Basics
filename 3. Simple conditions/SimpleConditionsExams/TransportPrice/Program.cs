using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var kmNum = int.Parse(Console.ReadLine());
            var TimeOfTheDay = Console.ReadLine();

            if (kmNum >= 100)
            {
                Console.WriteLine(kmNum * 0.06);
            }
            else if (kmNum >= 20)
            {
                Console.WriteLine(kmNum * 0.09);
            }
            else if (kmNum < 20 && TimeOfTheDay == "day")
            {
                Console.WriteLine(0.7 + kmNum * 0.79);
            }
            else
            {
                Console.WriteLine(0.7 + kmNum * 0.9);
            }
        }
    }
}
