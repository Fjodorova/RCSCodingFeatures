using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            Console.WriteLine("Please enter your name and age:");
            string usersName;
            usersName = Console.ReadLine();
            string usersAge;
            usersAge = Console.ReadLine();
            Console.WriteLine("Labdien," + usersName + "Tavs vecums ir:" + usersAge + "!");
            Console.ReadLine();
            
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        
    }
}
