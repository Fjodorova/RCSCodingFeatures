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
            Console.WriteLine("Please enter your name:");
            string usersName;
            usersName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string Age;
            Age = Console.ReadLine();
            Age = Age + 100;
            Console.WriteLine("Labdien," + usersName + "Tavs vecums ir:" + Age + "!");
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        
    }
}
