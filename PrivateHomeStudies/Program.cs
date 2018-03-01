using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateHomeStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            doWhileLoop();
        }

        static void syntaxings()
        {
            Console.WriteLine("Enter first name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", FirstName, LastName);
            Console.ReadKey();

        }

        static void minMaxValues()
        {
            int skaitlis = 7; //neatkarīgi no skaitļa, kas piešķirts.
            Console.WriteLine("Minimālā vērtība = {0}", int.MinValue);
            Console.WriteLine("Maksimālā vērtība = {0}", int.MaxValue);

            Console.ReadKey();
        }

        static void skaitlisArKomatu()
        {
            float skaitlis = 124.58745f; //float galā aiz skaitļa liek vienmēr f.
            decimal lielsSkaitlis = 1254.55547847566m; // decimal galā aiz skaitļa liek vienmēr m.
            Console.ReadKey();
        }

        static void pēdiņasTekstam()
        {
            string myName = "Inese";
            string namePēdiņās = "\"Inese\"";
            Console.WriteLine(myName + " or " + namePēdiņās);
            string nameZvaniņš = "\aInese";
            Console.WriteLine(nameZvaniņš);

            string atstarpe = "one\ntwo\ntree";
            Console.WriteLine(atstarpe);
            Console.ReadKey();
        }
        static void matemātiskasDarbības()
        {
            int dalāmais = 10;
            int dalītājs = 2;
            int result = dalāmais / dalītājs;
            Console.WriteLine("Rezultāts = {0}", result);

            int Dalāmais = 13;
            int Dalītājs = 2;
            int Result = Dalāmais % Dalītājs;
            Console.WriteLine("Rezultāts = {0}", Result);
            //ja dalās, rezultāts ir 0, ja nedalās, rezultāts ir atlikums.

            int dalāmaisD = 10;
            int dalītājsD = 2;
            if (dalāmaisD == 10 || dalītājsD == 1)
            {
                Console.WriteLine("Hello\n{0}", dalāmaisD);
            }
            Console.ReadKey();
        }

        static void jautājumaZīme()
        {
            int skaitlis = 10;
            bool VaiSkaitlisIr10;
            if (skaitlis == 10)
            {
                VaiSkaitlisIr10 = true;
            }
            else
            {
                VaiSkaitlisIr10 = false;
            }
            Console.WriteLine("Skaitlis 10 ir 10 == {0}", VaiSkaitlisIr10);

            int cipars = 8;
            bool vaiCiparsIrAstoņi = cipars == 8 ? true : false; // lasās kā: If cipars equals 8 then true else false.
            Console.WriteLine("Cipars 8 ir 8 == {0}", vaiCiparsIrAstoņi);

            Console.ReadKey();
        }

        static void nullesKlase()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Are you a major?");
            bool? areYouAMajor = null;
            {
                if (areYouAMajor == true) { Console.WriteLine("You are a major!"); }

                else if (areYouAMajor == false) { Console.WriteLine("You are not a major!"); }

                else { Console.WriteLine("You didn't answer the qustion!"); }
            }
            Console.ReadKey();
        }

        static void konvertesana()
        {
            float f = 123.45f;
            int i = (int)f; //var arī šādi   int i = Convert.ToInt32(f); ToInt32 vietā var lietot jekuru vajadzīgo.
            Console.WriteLine(i);
        }

        static void parsēšana()
        {
            string strNumber = "100DT";
            int result = 0;
            bool IsConverssionSuccess = int.TryParse(strNumber, out result);

            if (IsConverssionSuccess)
            { Console.WriteLine(result); }
            else { Console.WriteLine("Enter valid number!"); }

            Console.ReadKey();
        }

        static void cetrkantaināsBraketes()
        {
            int[] evenNumbers = new int[3];
            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            Console.WriteLine(evenNumbers[1]);
            Console.ReadKey();
        }

        /// <summary>
        /// trying to understand XML Documentation Comment.
        /// </summary>
        static void previousInOneLine()
        {
            int[] oddNumbers = { 1, 2, 3 };
            Console.WriteLine(oddNumbers[0]);
            Console.ReadKey();
        }

        static void ifElseParaugs()
        {
            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number == 10)
            { Console.WriteLine("Number is 10"); }
            else if (number == 20)
            { Console.WriteLine("Number is 20"); }
            else if (number == 30)
            { Console.WriteLine("Number is 30"); }
            else { Console.WriteLine("Number isn't 10, 20, 30"); }
            Console.ReadKey();
        }

        static void iepriekšējaiPiemērsSwitchTehnikā()
        {
            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                default:
                    Console.WriteLine("Number isn't 10, 20, 30");
                    break;
                    Console.ReadKey();
            }
        }

        static void caseVarLiktVairākusKopā()
        {
            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Number is {0}" + number);
                    break;
                default:
                    Console.WriteLine("Number isn't 10, 20, 30");
                    break;
                    Console.ReadKey();
            }

        }

        static void swičaApmācība()
        {
            double CoffeeCost = 0; //piešķir kāds būs iedotā vārda (CoffeeCost) iznākums, piem int, kas vienmēr piešķirot būs 0

            Start: //atgriešanāš simbols, lai sāktu darbību atkārtoti
            Console.WriteLine("Select coffee size: \n1 - Small \n2 - Medium \n3 - Large"); //komats atdala pēc secības - 1=small, 2=medium, 3=large
            int UsersChoice = int.Parse(Console.ReadLine());

            switch (UsersChoice)
            {
                case 1: //atbilst small
                    CoffeeCost += 1.25; //+= pievienot un ir vienāds
                    break;
                case 2: //medium
                    CoffeeCost += 2.50;
                    break;
                case 3: //large
                    CoffeeCost += 3.75;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UsersChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Would you like one more? - YES or NO");
            string UsersDecision = Console.ReadLine();

            switch (UsersDecision.ToUpper()) //ToUpper nozimē, ka lasīsies arī, ja ievada Yes, no, YEs...
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Try again:", UsersDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping!");
            Console.WriteLine("Your bill is: {0}", CoffeeCost);
            Console.ReadKey();
        }

        static void whileLoop()
        {
            Console.WriteLine("Please enter your target number:");
            int TargetNumber = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= TargetNumber) //while funkcija turpinās, kamēr iekavas nav piepildījušās.
            {
                Console.Write(Start + " "); //ja ir tikai Write, tad cipari būs vienā rinda 2 4 6 8, " " piešķir atstarpi
                Start = Start + 2;
                Console.ReadKey();
            }
        }

        static void doWhileLoop()
        {
            string UsersChoice = string.Empty;
            
            do
            {
                Console.WriteLine("Please enter your target number:");
                int TargetNumber = int.Parse(Console.ReadLine());

                int Start = 0;

                while (Start <= TargetNumber)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?:");
                    UsersChoice = Console.ReadLine().ToUpper();

                    if (UsersChoice != "YES" && UsersChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please enter Yes or No:");
                    } 

                } while (UsersChoice != "YES" && UsersChoice != "NO");

            } while (UsersChoice == "YES");
        }
    }
}
