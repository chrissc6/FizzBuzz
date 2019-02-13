using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 100;
            int a = 3;
            int b = 5;

            Console.WriteLine($"FizzBuzz. \nPrint Fizz for a number that has a multiple of {a}," +
                $" and Buzz for a number that has a multiple of {5}. \nAnd FizzBuzz if its a multiple " +
                $"of both {a} and {5}.");

            Console.WriteLine($"*FizzBuzz until 1-{total}.*");

            for (int i = 1; i < total; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("*Fizzbuzz done.*");
            Console.ReadLine();
        }
    }
}
