using System;

namespace FerbLatinTranslater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ferb Latin Translator");
            Console.WriteLine("Ferb Latin is fun and simple to learn.\n To speak it, one must move the first letter of every word of above two letters to the end of the word and add 'erb'.");
            Console.Write("Enter phrase to translate: ");
            string text =  Console.ReadLine();
            string newPhrase = FerbLatinise(text);
            Console.WriteLine(text);
            Console.WriteLine(newPhrase);
        }
        private static string FerbLatinise(string phrase)
        {
            //char[] seperatorChars = {' ', ',', '.', ':', '?', '\n', '\t'};
            string[] wordArray = phrase.Split(' ');
            string[] ordWerbrrayAerb = new string[wordArray.Length];
            int i = 0;
            string hrasePerb = "";
            foreach (var word in wordArray)
            {
                if (word.Length < 4)
                {
                    ordWerbrrayAerb[i] = word;
                }
                else
                {
                    string ordWerb = FerbLatin(word);
                    ordWerbrrayAerb[i] = ordWerb;
                }
                i++;
            }
            foreach (var ordWerb in ordWerbrrayAerb)
            {
                hrasePerb = hrasePerb + ordWerb + " ";
            }
            return hrasePerb;
        }

        private static string FerbLatin(string word)
        {
            //string temp = word;
            string newWord = "";
            int len = word.Length;
            for (var i = 1; i < len; i++)
            {
                newWord =newWord + word[i];
            }
            string firstLetter = word[0].ToString().ToUpper();
            newWord = newWord + firstLetter + "erb";
            return newWord;
        }
    }
}
