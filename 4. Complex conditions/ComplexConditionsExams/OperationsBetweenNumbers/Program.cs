using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            var result = 0.0;
            var evenOrOdd = "";



                if (symbol == "+")
                {
                    result = firstNumber + secondNumber;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, symbol, secondNumber, result, evenOrOdd);
                }
                else if (symbol == "-")
                {
                    result = firstNumber - secondNumber;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, symbol, secondNumber, result, evenOrOdd);
                }
                else if (symbol == "*")
                {
                    result = firstNumber * secondNumber;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumber, symbol, secondNumber, result, evenOrOdd);
                }


                else if (symbol == "/")
                {
                    if (firstNumber == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine("{0} / {1} = {2:f2}", firstNumber, secondNumber, result);
                    }
                }
                else if (symbol == "%")
                {
                    if (firstNumber == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                    }
                    else
                    {
                        result = firstNumber % secondNumber;
                        Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, result);
                    }
                }
            
        }
    }
}
