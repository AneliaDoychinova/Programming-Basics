using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());

            var carNum = 0.0;
            var microbusNum = 0.0;
            var minibusNum = 0.0;
            var autobusNum = 0.0;
            var trainNum = 0.0;
            var count = 0.0;
            for (int i = 0; i < groupsCount; i++)
            {
                var studentsNumber = int.Parse(Console.ReadLine());
                count += studentsNumber;

                if (studentsNumber <= 5)
                {
                    carNum += studentsNumber;
                }
                else if (studentsNumber > 5 && studentsNumber <= 12)
                {
                    microbusNum += studentsNumber;
                }
                else if (studentsNumber > 12 && studentsNumber <= 25 )
                {
                    minibusNum += studentsNumber;
                }
                else if (studentsNumber > 25 && studentsNumber <= 40)
                {
                    autobusNum += studentsNumber;
                }
                else
                {
                    trainNum += studentsNumber;
                }

            }

            var carPercent = carNum / count * 100;
            var microbusPercent = microbusNum / count * 100;
            var minibusPercent = minibusNum / count * 100;
            var autobusPercent = autobusNum / count * 100;
            var trainPercent = trainNum / count * 100;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", microbusPercent);
            Console.WriteLine("{0:f2}%",minibusPercent);
            Console.WriteLine("{0:f2}%", autobusPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
