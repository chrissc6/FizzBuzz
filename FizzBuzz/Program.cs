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



            Console.WriteLine($"FizzBuzz. \nPrint Fizz for a number that is a multiple of {a}," +
                $" and Buzz for a number that is a multiple of {b}. \nAnd FizzBuzz if its a multiple " +
                $"of both {a} and {b}.");

            Console.WriteLine($"*FizzBuzz until 1-{total}.*");

            for (int i = 1; i < total; i++)
            {
                //even better way, you can now add more numbers and words

                int[] ints = new int[] { 3, 5, 7, 11 };
                string[] strs = new string[] { "Fizz", "Buzz", "Fuzz", "Bizz" };

                string output = "";
                int y = 0;
                string strA = strs[0];
                int z = 0;

                while (y == 0)
                {
                    foreach (int x in ints)
                    {
                        var ele = Array.FindIndex(ints, idx => idx == x);
                        z = ele;
                        if (i % x == 0)
                        {
                            strA = strs[z];
                            output += strA;
                        }
                    }
                    y = 1;
                    z = 0;
                    if (output == "") { Console.WriteLine(i); }
                    else Console.WriteLine(output);
                }






                ////better way
                //string output = "";

                //if(i % a == 0) { output += "Fizz"; }
                //if(i % b == 0) { output += "Buzz"; }
                ////could easy add more than two numbers now

                //if (output == "") { Console.WriteLine(i); }
                //else { Console.WriteLine(output); }


                //if(i % a == 0 && i % b == 0)
                //{
                //    Console.WriteLine("FizzBuzz");
                //}
                //else if(i % a == 0)
                //{
                //    Console.WriteLine("Fizz");
                //}
                //else if(i % b == 0)
                //{
                //    Console.WriteLine("Buzz");
                //}
                //else
                //    Console.WriteLine(i);
            }

            Console.WriteLine("*Fizzbuzz done.*");
            Console.ReadLine();
        }
    }
}
