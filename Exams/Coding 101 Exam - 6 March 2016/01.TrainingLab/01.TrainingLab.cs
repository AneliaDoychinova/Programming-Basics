using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var hallway = 100;
            var desks = Math.Floor(((width * 100) - hallway) / 70);
            var rows = Math.Floor((lenght * 100) / 120);

            var places = desks * rows - 3;

            Console.WriteLine(places);
        }
    }
}
