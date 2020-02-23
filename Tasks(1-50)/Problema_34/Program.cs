using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_34
{
    class Program
    {
////        Two Coins
////Time limit: 1220 ms
////Memory limit: 258.5 MB

////You are given NN coins, where the ii-th coin has a value of v_iv
////​i
////​​ , for each ii between 11 and NN.How many different amounts can you pay using exactly 2 coins?
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            List<int> tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();

            List<int> values = new List<int>();

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    values.Add(tokens[i] + tokens[j]);
                }
            }

            Console.WriteLine(values.GroupBy(x => x).Count()); 
        }
    }
}
