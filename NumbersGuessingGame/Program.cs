using System;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            theGame();
            //internetLearning();
            //lerarnAtHome();
        }

        static void internetLearning()
        {
            int number1, number2;
            Console.WriteLine("Please enter a number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. One more:");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adding the two numbers: " + (number1 + number2));
            Console.ReadLine();
        }

        static void lerarnAtHome()
        {
            int number = 1;
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
            }
            Console.ReadLine();
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

            for (int numGuesses = 1; numGuesses<=4 && !correct; numGuesses = numGuesses +1)
            {
                Console.WriteLine("Your guessing " + numGuesses + " time!");

                Console.Write("Guess:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
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