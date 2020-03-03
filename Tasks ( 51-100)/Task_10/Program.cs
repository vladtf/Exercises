using System;
using System.Linq;

namespace Task_10
{
    internal class Program
    {
        //        Alternant Array
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You have a binary array VV of size 2 * N2∗N composed of NN values of 00 and NN values of 11. You can swap any two elements.What is the minimum number of swaps to make the array alternant? A binary array is /alternant/ if no two consecutive elements are equal.
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < tokens.Count(); i += 2)
            {
                if (tokens[i] != 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            Console.WriteLine(Math.Min(count1, count2));
        }
    }
}