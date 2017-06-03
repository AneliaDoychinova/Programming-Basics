using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsNumber = int.Parse(Console.ReadLine());

            var averageGrade = 0.0;
            var failStudents = 0.0;
            var aboveThree = 0.0;
            var aboveFour = 0.0;
            var topStudents = 0.0;

            for (int i = 0; i < studentsNumber; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                averageGrade += grade;

                if (grade < 3)
                {
                    failStudents++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    aboveThree++;
                }
                else if (grade >=4 && grade < 5)
	            {
                    aboveFour++;
	            }
                else
                {
                    topStudents++;
                }

            }

            var topStudentsPercent = topStudents / studentsNumber * 100;
            var aboveFourPercent = aboveFour / studentsNumber * 100;
            var aboveThreePercent = aboveThree / studentsNumber * 100;
            var failStidentsPercent = failStudents / studentsNumber * 100;

            averageGrade = averageGrade / studentsNumber;

            Console.WriteLine("Top students: {0:f2}%", topStudentsPercent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", aboveFourPercent);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", aboveThreePercent);
            Console.WriteLine("Fail: {0:f2}%", failStidentsPercent);
            Console.WriteLine("Average: {0:F2}", averageGrade);
        }
    }
}
