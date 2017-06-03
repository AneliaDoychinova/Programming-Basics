using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrival = int.Parse(Console.ReadLine());
            var minuteArrival = int.Parse(Console.ReadLine());

            var examInMinutes = hourExam * 60 + minuteExam;
            var arrivalInMinutes = hourArrival * 60 + minuteArrival;
            var differenceLate = Math.Abs(arrivalInMinutes - examInMinutes);
            var differenceEarly = Math.Abs(examInMinutes - arrivalInMinutes);

            if (arrivalInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                if (differenceLate < 60)
                {
                    Console.WriteLine("{0} minutes after the start", differenceLate);
                }
                else
                {
                    var hour = differenceLate / 60;
                    var minutes = differenceLate % 60;
                    Console.WriteLine("{0}:{1:00} hours after the start", hour, minutes);
                }
            }
            else if (differenceEarly >= 0 && differenceEarly <= 30)
            {
                Console.WriteLine("On time");
                if (differenceEarly > 0)
                {
                    Console.WriteLine("{0} minutes before the start", differenceEarly);
                }
                
            }
            else if (differenceEarly > 30)
            {  
                Console.WriteLine("Early");
                if (differenceEarly > 59)
                {
                    var hour = differenceEarly / 60;
                    var minutes = differenceEarly % 60;
                    Console.WriteLine("{0}:{1:00} hours before the start", hour, minutes);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", differenceEarly);
                }
              
            }
           
        }
    }
}
