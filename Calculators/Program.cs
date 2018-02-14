using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateCircleArea();
        }

        static void CalculateCircleArea()
        {
            double radius;
            double result;
            radius = GetNumberFromUser("Lūdzu ievadiet rādiusu:");
            result = radius * radius * 3.14;
            Console.WriteLine("Rezultāts:" + result);
            Console.ReadLine();
        }

       

        static void CountTwoNumbersTogether()
        {
            double firstNumber;
            firstNumber = GetNumberFromUser("Lūdzu, ievadiet pirmo skaitli:");
            double secondNumber;
            secondNumber = GetNumberFromUser("Lūdzu, ievadiet pirmo skaitli:");
            double result;
            result = firstNumber + secondNumber;
            Console.WriteLine("Apreķināts Rezultāts:" + result);
            Console.ReadLine();
        }

        static double GetNumberFromUser(string msg)
        {
            Console.WriteLine(msg);
            string textInput = Console.ReadLine();
            double parsedNumber;
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("Slikti ievadīts skaitlis" + textInput + "");
                Console.WriteLine("Ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            return parsedNumber;
        }
    }
}
