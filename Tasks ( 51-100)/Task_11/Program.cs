using System;
using System.Linq;

namespace Task_11
{
    internal class Program
    {
        //        Max Wave Array
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //An array AA is called wave array if A_1 > A_2<A_3> A_4< ...A
        //Given an array AA, permute its elements such that it becomes a wave array. If the solution is not unique, find the largest lexicographical one.
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).OrderByDescending(x => x).ToList();

            for (int i = 1; i < tokens.Count() - 1; i += 2)
            {
                int aux = tokens[i];
                tokens[i] = tokens[i + 1];
                tokens[i + 1] = aux;
            }

            tokens.ForEach(x => Console.Write(x + " "));
        }
    }
}