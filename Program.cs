using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
             {
                bool run = true;

                Console.WriteLine("Please Play Pig Latin Translator!");

                do
                {
                    Console.Write("\nEnter a word to be translated: ");
                    string userWord = Console.ReadLine();
                    string[] createdWord = userWord.Split(' ');
                    Translation(createdWord);
                    run = Cont();

                } while (run == true);

            }
        public static void Translation(string[] userWord)
        {
            for (int i = 0; i < userWord.Length; i++)
            {
                if (userWord[i].StartsWith("a") || userWord[i].StartsWith("e") || userWord[i].StartsWith("i") || userWord[i].StartsWith("o") || userWord[i].StartsWith("u"))
                {
                    Console.Write(userWord[i] + "way ");
                }

                else
                {
                    int pos = userWord[i].IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'y' });

                    string translation = userWord[i].Substring(0, pos);

                    string userWord1 = userWord[i] + translation;

                    string createdWord = userWord1.Remove(0, pos);

                    Console.Write(createdWord + "ay ");

                }

            }
        }

        public static bool Cont()
        {
            bool run = true;
            Console.Write("\n\nContinue?(y/n) ");
            string cont = Console.ReadLine();


            if (cont == "n")
            {
                Console.WriteLine("\nNice Job!");
                run = false;
            }
            return run;
        }
    }
}
    