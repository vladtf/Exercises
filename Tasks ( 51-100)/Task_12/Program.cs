using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_12
{
    internal class Program
    {
        //        Bounded Distinct
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //You are given an array of NN integers.Find the number of subarrays having a length between LL and RR that contain only distinct elements.
        private static void Main(string[] args)
        {
            var tokens = ReadIntArray();

            int n = tokens[0];
            int l = tokens[1];
            int r = tokens[2];

            tokens = ReadIntArray();

            var temp = new List<int>();
            temp.Add(tokens[0]);

            int ans = 0;

            for (int i = 1; i < tokens.Count(); i++)
            {
                if (temp.Count >= l && temp.Count <= r)
                    ans++;

                while (temp.Contains(tokens[i]))
                {
                    temp.RemoveAt(0);
                }
                temp.Add(tokens[i]);

                if (temp.Count >= l)
                {
                    ans += temp.Count - l + 1;
                }
            }
            Console.WriteLine(ans);
        }

        private static List<int> ReadIntArray()
        {
            return Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();
        }
    }
}