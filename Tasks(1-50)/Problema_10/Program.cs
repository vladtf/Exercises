using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_10
{
    //    Odd Divisors
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //You are given an interval of integers[A, B][A, B]. For each number in this interval compute its greatest odd divisor. Output the sum of these divisors.
    internal class Program
    {
        private static long Sum(long x)
        {
            if (x == 0)
                return 0;
            if (x % 2 == 0)
                return ((x + 1) / 2) * ((x + 1) / 2) + Sum(x / 2);
            else
                return x + Sum(x - 1);
        }

        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<long> ans = new List<long>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').Select(x => Int64.Parse(x)).ToList();

                Console.WriteLine(Sum(tokens[1]) - Sum(tokens[0] - 1));
            }
        }
    }
}