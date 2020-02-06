using System;
using System.Linq;

namespace Problema_38
{
    class Program
    {
        //You are given a word SS consisting of lowercase English letters.Each letter takes a certain given amount of time to print.How long will it take to print the whole word?
        static void Main(string[] args)
        {
            var lettersCount = Console.ReadLine().ToCharArray().GroupBy(x => x).ToList();
            var time = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            var ans = lettersCount.Select(x => time[x.First() - 'a'] * x.Count()).Sum();
            Console.WriteLine(ans);
        }
        //class Solution
        //{
        //    void Solve()
        //    {
        //        string s = ReadLine();
        //        int[] times = ReadInts();
        //        int ans = 0;
        //        foreach (char c in s)
        //        {
        //            ans += times[c - 'a'];
        //        }
        //        Println(ans);
        //    }

        //    static void Main(string[] args) { new Solution().Solve(); }

        //    static string ReadLine() { return Console.ReadLine(); }
        //    static string[] ReadTokens() { return ReadLine().Split(new char[] { ' ' }); }
        //    static int[] ReadInts() { return ConvertAll(ReadTokens(), int.Parse); }

        //    static void Println(object o) { Console.WriteLine(o); }
        //    static void Print(object o) { Console.Write(o); }
        //}
    }
}
