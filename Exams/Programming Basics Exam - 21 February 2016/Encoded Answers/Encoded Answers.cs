using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfQuestions = int.Parse(Console.ReadLine());

            var answerA = 0;
            var answerB = 0;
            var answerC = 0;
            var answerD = 0;

            
            var result = "";

            for (int i = 0; i < numberOfQuestions; i++)
            {
                var questionNum = decimal.Parse(Console.ReadLine());
                string answer = null;

                if (questionNum % 4 == 0)
                {
                   answer = "a";
                    answerA++;

                }
                else if (questionNum % 4 == 1)
                {
                    answer = "b";
                        answerB++;
                }
                else if (questionNum % 4 == 2)
                {
                    answer = "c";
                    answerC++;
                }
                else if (questionNum % 4 == 3)
                {
                    answer = "d";
                    answerD++;
                }
                result = result + " " + answer;
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}", answerA);
            Console.WriteLine("Answer B: {0}", answerB);
            Console.WriteLine("Answer C: {0}", answerC);
            Console.WriteLine("Answer D: {0}", answerD);

        }
    }
}
