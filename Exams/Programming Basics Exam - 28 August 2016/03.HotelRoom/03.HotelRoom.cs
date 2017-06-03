using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0;
            var apartment = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apartment = 65;
                    if (nights > 14)
                    {
                        studio = 50 * 0.7;
                        apartment = 65 * 0.9;
                    }
                    else if (nights > 7)
                    {
                        studio = 50 * 0.95;
                     
                    }
                    break;
                    
                case "June":
                case "September":
                     studio = 75.2;
                    apartment = 68.7;
                    if (nights > 14)
                    {
                        studio = 75.2 * 0.8;
                        apartment = 68.7 * 0.9;
                    }
                    break;

                case "July":
                case "August":
                    studio = 76;
                    apartment = 77;

                    if (nights > 14)
                    {
                        apartment = 77 * 0.9;
                    }
                break;
            }

            var apartmentPrice = nights * apartment;
            var studioPrice = nights * studio;

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
