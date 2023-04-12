using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cslight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'ts your calculator ");
            Console.WriteLine("What you wonna do? + - * / ");
            string calculator = Console.ReadLine();
            Console.WriteLine("Enter first value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (calculator)
            {
                case "+":
                    int sum = x + y;
                    Console.WriteLine("You have" + sum);
                    break;
                case "-":
                    int minus = x - y;
                    Console.WriteLine("You have" + minus);
                    break;
                case "*":
                    int multiply = x * y;
                    Console.WriteLine("You have " + multiply);
                    break;

                case "/":
                    int divade = x / y;
                    Console.WriteLine("You have" + divade);
                    break;
                default:
                    Console.WriteLine("You do unknown  action");
                    break;
            }

        }
    }
}
