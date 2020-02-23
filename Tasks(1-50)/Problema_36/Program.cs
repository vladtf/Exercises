using System;
using System.Linq;

namespace Problema_36
{
    class Program
    {
        /*
         * Xor Match
         * Time limit: 1220 ms
         * Memory limit: 258.5 MB
         * You are given two binary arrays, AA of size NN and BB of size MM, N \leq MN≤M. We consider the arrays to be 0-indexed.
         * A xor-match is an occurrence of the binary complement of AA in BB. Formally, it is an index jj, 0 \leq j \leq M - N0≤j≤M−N, such that A_i + B_{i+j} = 1A
         * i​​ +B​i+j​​ =1, for all 0 \leq i < N0≤i<N.
         * Find the number of xor-matches.
         */
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();
            int n = tokens[0];
            int m = tokens[1];

            int[] A = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();

            int ans = 0;
            for (int i = 0; i < m-n+1; i++)
            {
                bool ok = true;
                for (int j = 0; j < n && ok; j++)
                {
                    if (A[j] + B[i+j] != 1)
                    {
                        ok = false;
                    }
                }
                if (ok)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
