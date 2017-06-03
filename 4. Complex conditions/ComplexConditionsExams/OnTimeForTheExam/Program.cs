using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrival = int.Parse(Console.ReadLine());
            var minuteArrival = int.Parse(Console.ReadLine());

            var ExamTime = hourExam * 60 + minuteExam;
            var ArrivalTime = hourArrival * 60 + minuteArrival;
            var differenceEarly = ExamTime - ArrivalTime;
            var differenceLate = ArrivalTime - ExamTime;

            if (differenceLate > 0 && differenceLate <=59)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", differenceLate);
            }
            else if (differenceLate > 59)
            {
                var hours = differenceLate/60;
                var minutes = differenceLate % 60;
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} hours after the start",hours, minutes );
            }
            else if (differenceLate == 0)
            {
                Console.WriteLine("On time");
            }
            else if(differenceEarly > 0 && differenceEarly <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", differenceEarly);
            }
            else if (differenceEarly > 30 && differenceEarly <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", differenceEarly);
            }
            else if (differenceEarly > 59)
            {
                var hours = differenceEarly / 60;
                var minutes = differenceEarly % 60;
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
            }

        }
    }
}
