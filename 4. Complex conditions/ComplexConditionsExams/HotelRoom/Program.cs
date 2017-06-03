using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsNum = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {   
                
                if (nightsNum > 14)
                {
                    studioPrice = 50 - (0.3 * 50);
                    apartmentPrice = 65 - (0.1 * 65);
                }
                else if (nightsNum > 7)
                {
                    studioPrice = 50 - (0.05 * 50);
                    apartmentPrice = 65;

                }
            
               
                
                else
                {
                    studioPrice = 50;
                    apartmentPrice = 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nightsNum > 14)
                {
                    studioPrice = 75.2 - (0.2 * 75.2);
                    apartmentPrice = 68.7 - (0.1 * 68.7);

                }
                else
                {
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                }

            }
            else if (month == "July" || month == "August")
	        {
                studioPrice = 76;

		        if (nightsNum > 14)
	            {

                    apartmentPrice = 77 - (0.1 * 77);
	            }
                else
                {
                    
                    apartmentPrice = 77;
                }
	            
	        }

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice * nightsNum);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nightsNum);
                
            }
        }
    }
