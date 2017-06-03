using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            var patients = 0;
            var untreated = 0;
            var treated = 0;
            var doctors = 7;

            var totalTreated = 0;
            var totalUntreated = 0;

            for (int i = 1; i <= days; i++)
            {
                 if (i % 3 == 0 && totalUntreated > totalTreated)
	                {
                        doctors++;
	                }

                patients = int.Parse(Console.ReadLine());


                if (patients > doctors)
                {
                    untreated = patients - doctors;
                    treated = patients - untreated;
                   
                }
                else
                {
                    treated = patients;
                    untreated = 0;
                }
                totalUntreated += untreated;
                totalTreated += treated;

                   
            }
            Console.WriteLine("Treated patients: {0}.", totalTreated);
            Console.WriteLine("Untreated patients: {0}.", totalUntreated);
        }
    }
}
