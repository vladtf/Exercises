using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_35
{
    class Program
    {
////        Open the Bottles
////Time limit: 1220 ms
////Memory limit: 258.5 MB

////You have 33 wine bottles and 33 bottle openers.You know the time necessary to open each bottle using each opener.Find the minimum total time for opening all 33 bottles.
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            List<int> line2 = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            List<int> line3 = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();

            List<int> values = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int t = 0; t < 3; t++)
                    {
                        values.Add(line1[i] + line2[j] + line3[t]);
                    }
                }
            }

            Console.WriteLine(values.Min());
        }
    }
}
