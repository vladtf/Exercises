using System;
using System.Collections.Generic;

namespace Problema_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Word> words = new List<Word>();

            Word word = new Word();

            word.Str = "";

            while (word.Str != "n")
            {
                word = new Word();
                Console.Write("Citeste sirul de caractere : ");
                word.Citire();

                if (word.Str != "n")
                {
                    words.Add(word);
                }
            }

            foreach (Word word1 in words)
            {
                Console.WriteLine($"S-a citit sirul {word1.Str} cu lungimea = {word1.Str.Length.ToString()}");
            }

            Console.ReadLine();
        }
    }

    internal class Word
    {
        public string Str;

        public void Citire()
        {
            Str = Console.ReadLine();
        }
    }
}