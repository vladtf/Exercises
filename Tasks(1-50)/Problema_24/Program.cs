using System;
using System.Linq;

namespace Problema_24
{
    /*
     * Min Pairing
Time limit: 1220 ms
Memory limit: 130.5 MB

You have an array AA of NN integers, NN is always even. You should group the numbers in N/2N/2 pairs. For each pair you calculate the absolute difference between the two elements. You want to minimize the sum of all the absolute differences.
     */
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).OrderByDescending(x => x).ToArray();

            int dif = 0;
            for (int i = 0; i < n; i += 2)
            {
                dif += tokens[i] - tokens[i + 1];
            }

            Console.WriteLine(dif);
        }
    }
}