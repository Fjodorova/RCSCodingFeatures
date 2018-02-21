using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
            // ielādējam visus vārdus no vārdnīcas faila
            // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
            // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
            // pārbaudam, vai burts atrodas vārdnīcas vārdā
            // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
            
            // kad vārdu apstrāde pa burtiem beigusies,
            // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
            // ja nav, tad izvadām vārdu uz ekrāna
            Console.WriteLine("Please enter a Word from which we will look for letters in alphabeth:");
            string usersLetters = Console.ReadLine();

            string[] wordsFromDictionary = File.ReadAllLines(@"C:\Users\selfishscream\Favorites\Downloads\words.txt.);


            foreach (string wordFromDict in wordsFromDictionary)
            {
                bool hasInvalidLettersBeenFound = false;
                for (int i = 0; i < usersLetters.Length; i++)
                {
                    char currentSymbol = usersLetters[i];
                    if (wordFromDict.Contains(currentSymbol) == false)
                    {
                        hasInvalidLettersBeenFound = true;
                    }
                }
                Console.WriteLine(wordsFromDictionary + "ir atrasti burti, kas ir lietotāja norādītajā vārdā" + !hasInvalidLettersBeenFound);
                foreach(char symbol in wordFromDict)
                {
                    if (usersLetters.Contains(symbol)==false)
                    {
                        hasInvalidLettersBeenFound = true;
                    }
                    if(hasInvalidLettersBeenFound == false)
                    {
                        Console.WriteLine(wordFromDict);
                    }
                }
            }

            // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
            // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
            // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
        }
    }
}
