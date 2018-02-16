using System;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            theGame();
        }


        static void theGame()
        {
            Console.WriteLine("What would be the max number, starting from one, you would like to guess?");
            int maxNumber = int.Parse(Console.ReadLine());

            Random guestNumber = new Random();
            int returnValue = guestNumber.Next(1, maxNumber);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("I'm thinking of a number between 1 and " + maxNumber + " Can you guess it?");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out returnValue))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < returnValue)
                {
                    Console.WriteLine("No, the number I'm thinking is higher than that number.");
                }
                else if (guess > returnValue)
                {
                    Console.WriteLine("No, the number I'm thinking is lower than that number.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right!");
                }
            }
        }

    

    static void learning()
        {
            Random diceNumberGenetator;
            diceNumberGenetator = new Random();
            int diceValue = diceNumberGenetator.Next(1, 7);
            Console.WriteLine("Tavs kauliņa metiens:" + diceValue);
            int secondDiceValue = diceNumberGenetator.Next(0, 101);
            Console.WriteLine("Tavs Otra kauliņa metiens" + secondDiceValue);
            Console.ReadLine();
        }

    }
}