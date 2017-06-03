using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoinNum = int.Parse(Console.ReadLine());
            var chineseYuansNum = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var bitcoinToLeva = 1168;
            var yuansToDollars = 0.15;
            var dollarToLev = 1.76;
            var euroToLev = 1.95;

            var yuansToLeva = chineseYuansNum * yuansToDollars * dollarToLev;
            var bitcoinToLevaSum = bitcoinNum * bitcoinToLeva;

            var levaSum = yuansToLeva + bitcoinToLevaSum;
            var levaToEuro = levaSum / euroToLev;

            var totalEuro = levaToEuro - (levaToEuro * comission * 0.01);

            Console.WriteLine(totalEuro);

        }
    }
}
