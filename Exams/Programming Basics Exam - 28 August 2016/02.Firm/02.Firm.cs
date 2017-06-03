using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workersOvertime = int.Parse(Console.ReadLine());

            var trainingDays = days * 0.1;
            var workingHours = (days - trainingDays) * 8;

            var overtimeHours = workersOvertime * 2 * days;
            var totalHours = Math.Floor(workingHours + overtimeHours);

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - totalHours);
            }

        }
    }
}
