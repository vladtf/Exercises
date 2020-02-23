using System;
using System.Collections.Generic;

namespace Problema_6
{
    //    3-divisible Pairs
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //You are given an array of NN positive integers.Compute the number of pairs of integers in the array that have the sum divisible by 33.
    internal class Program
    {
        private static void Main(string[] args)
        {
            string n = Console.ReadLine();

            List<int> vec = new List<int>();

            long nr = 0;

            string line = Console.ReadLine();

            line = line.TrimStart().TrimEnd();

            string[] data = line.Split(' ');

            vec.AddRange(Array.ConvertAll(data, int.Parse));

            long od = 0;
            long dv = 0;

            foreach (int x in vec)
            {
                if (x % 3 == 0)
                    nr++;
                if (x % 3 == 1)
                {
                    od++;
                }
                if (x % 3 == 2)
                {
                    dv++;
                }
            }

            long res = nr * (nr - 1) / 2;
            res += od * dv;
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}