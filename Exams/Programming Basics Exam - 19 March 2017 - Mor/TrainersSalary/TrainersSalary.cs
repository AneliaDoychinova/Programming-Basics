using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            var lecturesNum = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var Jelev = 0.0;
            var RoYal = 0.0;
            var Roli = 0.0;
            var Trofon = 0.0;
            var Sino = 0.0;
            var others = 0.0;

            for (int i = 0; i < lecturesNum; i++)
            {
                var lectorName = Console.ReadLine();

                if (lectorName == "Jelev")
                {
                    Jelev++;
                }
                else if (lectorName == "RoYaL")
                {
                    RoYal++;
                }
                else if (lectorName == "Roli")
                {
                    Roli++;
                }
                else if (lectorName == "Trofon")
                {
                    Trofon++;
                }
                else if (lectorName == "Sino")
                {
                    Sino++;
                }
                else
                {
                    others++;
                }
            }
            var salary = budget / lecturesNum;
            Console.WriteLine("Jelev salary: {0:f2} lv", Jelev * salary );
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYal * salary);
            Console.WriteLine("Roli salary: {0:f2} lv", Roli * salary);
            Console.WriteLine("Trofon salary: {0:f2} lv", Trofon * salary);
            Console.WriteLine("Sino salary: {0:f2} lv", Sino * salary);
            Console.WriteLine("Others salary: {0:f2} lv", others * salary);
        }
    }
}
