using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            var evenNum = 0;
            var isInvalidNumber = true;
            do
            {
                try
                {
                    isInvalidNumber = false;
                    Console.Write("Enter even number: ");
                    evenNum = int.Parse(Console.ReadLine());

                    if (Math.Abs(evenNum % 2) == 1)
                    {
                        isInvalidNumber = true;
                        Console.WriteLine("The number is not even.");

                    }

                }
                catch (Exception)
                {
                    isInvalidNumber = true;
                    Console.WriteLine("Invalid number!");
                }
            }
            while (isInvalidNumber);
	  
                Console.WriteLine("Even number entered: {0}", evenNum);
        }
    }

}
