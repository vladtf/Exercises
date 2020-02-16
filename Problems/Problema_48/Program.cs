using System;
using System.Runtime.CompilerServices;

namespace Problema_48
{
    class Program
    {
        //        Adjacent Vowels
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You are given a string SS consisting of NN lowercase letters of the English alphabet.Count the number of adjacent pairs of vowels.

        //In this problem, we consider there are 55 letters that represent vowels: a, e, i, o and u.

        //Standard input
        static bool IsVowel(char s)
        {
            string vow = "aeiou";
            if (vow.Contains(s.ToString()))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (IsVowel(str[i]) && IsVowel(str[i + 1]))
                    ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
