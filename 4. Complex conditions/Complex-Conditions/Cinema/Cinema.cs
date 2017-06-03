using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var typeProjection = Console.ReadLine().ToLower();
            var rowsNumber = int.Parse(Console.ReadLine());
            var columnsNumber = int.Parse(Console.ReadLine());

            var price = 0.0;
            var seats = rowsNumber * columnsNumber;

            if (typeProjection == "premiere")
            {
                price = 12;
            }
            else if (typeProjection == "normal")
            {
                price = 7.5;
            }
            else if (typeProjection == "discount")
            {
                price = 5;
            }

            var totalIncome = seats * price;
            Console.WriteLine("{0:f2}", totalIncome);

        }
    }
}
