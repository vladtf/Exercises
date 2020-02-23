using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            List<string> words = new List<string>();

            List<Anagram> anagrams = new List<Anagram>();

            for (int i = 0; i < n; i++)
            {
                char[] word = Console.ReadLine().ToCharArray();

                Array.Sort(word);

                words.Add(new string(word));
            }

            anagrams.Add(new Anagram { Word = words.First(), Count = 0 });

            int max = 0;

            foreach (var word in words)
            {
                bool ok = false;
                foreach (var item in anagrams)
                {
                    if (String.Compare(word, item.Word) == 0)
                    {
                        item.Count++;

                        if (item.Count > max) max = item.Count;

                        ok = true;
                        break;
                    }
                }
                if (!ok) anagrams.Add(new Anagram { Word = word, Count = 1 });
            }

            Console.WriteLine(max.ToString());

            Console.ReadLine();
        }
    }

    internal class Anagram
    {
        public int Count { get; set; } = 1;
        public string Word { get; set; }
    }
}