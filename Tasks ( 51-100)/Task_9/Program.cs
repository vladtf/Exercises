using System;
using System.Linq;

namespace Task_9
{
    internal class Program
    {
        //        Monotone Subarray
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You are given an array AA of size NN.Consider the following definitions:

        //An array is non-increasing if for every ii, A_i \geq A_{ i + 1}
        //        A
        //​i
        //​​ ≥A
        //​i+1
        //​​ .
        //Similarly, it is non-decreasing if for every ii, A_i \leq A_ { i+1}
        //        A
        //​i
        //​​ ≤A
        //​i+1
        //​​ .
        //An array is monotone if it is non-increasing or non-decreasing.
        //Find the longest monotone subarray.
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

            int l = 1;
            int lmax = l;
            for (int i = 1; i < n; i++)
            {
                if (tokens[i - 1] <= tokens[i])
                {
                    l++;

                    if (l > lmax)
                    {
                        lmax = l;
                    }
                }
                else
                {
                    l = 1;
                }
            }

            l = 1;
            for (int i = 1; i < n; i++)
            {
                if (tokens[i - 1] >= tokens[i])
                {
                    l++;

                    if (l > lmax)
                    {
                        lmax = l;
                    }
                }
                else
                {
                    l = 1;
                }
            }

            Console.WriteLine(lmax);
        }
    }
}