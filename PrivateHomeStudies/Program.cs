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
            jautājumaZīme();
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
    }
}
