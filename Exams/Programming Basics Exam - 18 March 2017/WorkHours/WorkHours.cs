using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workersNum = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var workingHours = workersNum * workingDays * 8;

            if (workingHours >= hoursNeeded)
            {
                Console.WriteLine("{0} hours left", workingHours - hoursNeeded); 
            }
            else
            {
                var penalties = (hoursNeeded - workingHours) * workingDays;

                Console.WriteLine("{0} overtime", hoursNeeded - workingHours);
                Console.WriteLine("Penalties: {0}", penalties);
            }

        }
    }
}
