using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var firstMetric = Console.ReadLine().ToLower();
            var secondMetric = Console.ReadLine().ToLower();

            var metersToMillimeters = 1000;
            var meterToCentimeters = 100;
            var meterToMiles = 0.000621371192;
            var meterToInches = 39.3700787;
            var meterToKilometers = 0.001;
            var meterToFeet = 3.2808399;
            var meterToYards = 1.0936133;

            var secondNum = 0.0;

            if (firstMetric == "m")
            {
                if (secondMetric == "m")
                {
                    secondNum = num;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards;
                }

            }
            if (firstMetric == "mm")
            {
                if (secondMetric == "mm")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / metersToMillimeters;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / metersToMillimeters;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / metersToMillimeters;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / metersToMillimeters;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / metersToMillimeters;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / metersToMillimeters;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / metersToMillimeters;
                }

            }
            if (firstMetric == "cm")
            {
                if (secondMetric == "cm")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToCentimeters;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToCentimeters;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToCentimeters;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / meterToCentimeters;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToCentimeters;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToCentimeters;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToCentimeters;
                }

            }
            if (firstMetric == "mi")
            {
                if (secondMetric == "mi")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToMiles;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToMiles;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToMiles;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / meterToMiles;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToMiles;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToMiles;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToMiles;
                }

            }
            if (firstMetric == "in")
            {
                if (secondMetric == "in")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToInches;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToInches;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToInches;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToInches;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToInches;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToInches;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToInches;
                }

            }
            if (firstMetric == "in")
            {
                if (secondMetric == "in")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToInches;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToInches;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToInches;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToInches;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToInches;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToInches;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToInches;
                }

            } 
            if (firstMetric == "km")
            {
                if (secondMetric == "km")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToKilometers;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToKilometers;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToKilometers;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToKilometers;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / meterToKilometers;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToKilometers;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToKilometers;
                }

            }
            if (firstMetric == "ft")
            {
                if (secondMetric == "ft")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToFeet;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToFeet;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToFeet;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToFeet;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / meterToFeet;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToFeet;
                }
                else if (secondMetric == "yd")
                {
                    secondNum = num * meterToYards / meterToFeet;
                }

            }
            if (firstMetric == "yd")
            {
                if (secondMetric == "yd")
                {
                    secondNum = num;
                }
                else if (secondMetric == "m")
                {
                    secondNum = num / meterToYards;
                }
                else if (secondMetric == "mm")
                {
                    secondNum = num * metersToMillimeters / meterToYards;
                }
                else if (secondMetric == "cm")
                {
                    secondNum = num * meterToCentimeters / meterToYards;
                }
                else if (secondMetric == "mi")
                {
                    secondNum = num * meterToMiles / meterToYards;
                }
                else if (secondMetric == "in")
                {
                    secondNum = num * meterToInches / meterToYards;
                }
                else if (secondMetric == "km")
                {
                    secondNum = num * meterToKilometers / meterToYards;
                }
                else if (secondMetric == "ft")
                {
                    secondNum = num * meterToFeet / meterToYards;
                }

            }



            Console.WriteLine("{0} {1}", secondNum, secondMetric);
        }
    }
}
