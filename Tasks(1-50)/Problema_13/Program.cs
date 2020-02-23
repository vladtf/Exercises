using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            List<Word> words = new List<Word>();

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                words.Add(new Word { WordStr = word, Ord = i });
            }

            List<Word> orderedList = words.OrderBy(o => o.WordStr).ToList();

            foreach (var word in orderedList)
            {
                Console.Write(word.Ord + " ");
            }
        }
    }

    internal class Word
    {
        public string WordStr { get; set; }
        public int Ord { get; set; }
    }
}