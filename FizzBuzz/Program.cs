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
            Console.WriteLine("Please choose the maximum number:");
            var maxNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (var i = 1; i <= maxNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }


                else { Console.WriteLine(i); }

                Console.ReadLine();
            }
        }
    }
}
