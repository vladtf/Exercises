using System;
using System.Linq;

namespace Task_8
{
    internal class Program
    {
        //        0-Sum Array
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //You are given an array of NN integers.Find the smallest index of an element such that if you multiply it by -1−1 the sum of the whole array becomes 00.
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

            for (int i = 0; i < tokens.Count(); i++)
            {
                if (tokens.Sum() - 2 * tokens[i] == 0)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}