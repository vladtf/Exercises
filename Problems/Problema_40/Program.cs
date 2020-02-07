using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_40
{
    class Program
    {
//        Risk Rolls
//Time limit: 1220 ms
//Memory limit: 258.5 MB

//Alena and Boris are playing Risk today.We'll call an outcome the sum of values on the faces of 11 or more rolled dice. Alena has NN possible outcomes whilst Boris has MM. In turns, each one of them will choose their best possible available outcome and play it. If Alena's outcome is strictly greater than Boris's, then Alena wins; otherwise Boris wins. Whenever one of them runs out of outcomes, the game ends.

//In how many turns does Alena win? What about Boris?
        static void Main(string[] args)
        {
            List<int> token = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            int plays = token.Min();
            int n = token[0];
            int m = token[1];

            List<int> A = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).OrderByDescending(x => x).ToList().Take(plays).ToList();
            List<int> B = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).OrderByDescending(x => x).ToList().Take(plays).OrderBy(x => x).ToList();

            int count = 0;
            for (int i = 0; i < plays; i++)
            {
                if (A[i] > B[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count + " " + (plays-count));

        }
    }
}
