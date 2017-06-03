using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            var courses = int.Parse(Console.ReadLine());
            var points = 0.0;
            var result = 0.0;
            var firstCounter = 0.0;
            var secondCounter = 0.0;
            var thirdCounter = 0.0;
            var forthCounter = 0.0;
            var fifthCounter = 0.0;
            var sixthCounter = 0.0;

            for (int i = 0; i < courses; i++)
            {
                var number = int.Parse(Console.ReadLine());
                points = 0;

                if (number < 0 || number > 50)
                {
                    result /= 2;
                    sixthCounter++;
                }
                else if (number <= 9)
                {
                    points = 0.2 * number;
                    firstCounter++;
                }
                else if (number <=19)
                {
                    points = 0.3 * number;
                    secondCounter++;
                }
                else if (number <= 29 )
                {
                    points = 0.4 * number;
                    thirdCounter++;
                }
                else if (number <= 39)
                {
                    points = 50;
                    forthCounter++;
                }
                else
                {
                    points = 100;
                    fifthCounter++;
                }
                result += points;
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", firstCounter / courses * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", secondCounter / courses * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", thirdCounter / courses * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", forthCounter / courses * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", fifthCounter / courses * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", sixthCounter / courses * 100);
        }
    }
}
