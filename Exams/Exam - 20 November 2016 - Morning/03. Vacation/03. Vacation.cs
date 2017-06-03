using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var seniors = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nightsNum = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var nightPrice = 82.99;
            var seniorsTransportPrice = 0.0;
            var studentsTransportPrice = 0.0;

            switch (transport)
            {
                case "train":
                    if (seniors + students >= 50)
                    {
                        seniorsTransportPrice = 24.99 / 2;
                        studentsTransportPrice = 14.99 / 2;
                    }
                    else
                    {
                        seniorsTransportPrice = 24.99;
                        studentsTransportPrice = 14.99;
                    }
                    break;
                    
                    
                case "bus":
                    seniorsTransportPrice = 32.5;
                    studentsTransportPrice = 28.5;
                    break;
               
                case "boat":
                    seniorsTransportPrice = 42.99;
                    studentsTransportPrice = 39.99;
                    break;

                case "airplane":
                    seniorsTransportPrice = 70.0;
                    studentsTransportPrice = 50.0;
                    break;


            }
            var transportMoney = (seniors * seniorsTransportPrice + students * studentsTransportPrice) * 2;
            var hotelMoney = nightPrice * nightsNum;

            var comission = (transportMoney + hotelMoney) * 0.1;

            var totalSum = transportMoney + hotelMoney + comission;

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
