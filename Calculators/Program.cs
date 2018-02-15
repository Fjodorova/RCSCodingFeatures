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
            string usersInput = "";
            while (usersInput != "x")
            {
                Console.WriteLine("Please Choose Action");
                Console.WriteLine("a - Calculate Circle Area");
                Console.WriteLine("c - Count Two Numbers Together");
                usersInput = Console.ReadLine();
                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }
                else if (usersInput == "c") ;
                else if (usersInput == "d") ;
                else if (usersInput == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I didn't understand");
                }
            }
        }
        static void DoesTheNumberDevide()
        {
            double dalāmais = GetNumberFromUser("Lūdzu ievadiet dalāmo:");
            double dalītājs = GetNumberFromUser("Lūdzu ievadiet dalītāju:");
            double modulo = dalāmais % dalītājs;
            if (modulo == 0)
            {
                Console.WriteLine("Šie skaitļi dalās");
            }

            else
            {
                Console.WriteLine("Nedalās");
            }
            
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
