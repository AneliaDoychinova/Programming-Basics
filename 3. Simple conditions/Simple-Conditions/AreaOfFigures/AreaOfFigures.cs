﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var area = 0.0;

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                area = a * h / 2;

            }
            Console.WriteLine("{0:f3}", area);
        }
    }
}
