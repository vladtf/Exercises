using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_33
{
    internal class Program
    {

        //    Expected Dice
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //You have two special dice with 66 faces, each.For each dice you know the numbers written on each face.

        //You roll the two dices at the same time, and you add up the numbers showing on the upper faces.What is the most probable sum value you'll get?
        private static void Main(string[] args)
        {
            //var x = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).GroupBy(x => x).OrderByDescending(group => group.Count()).First().First();
            //var y = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).GroupBy(x => x).OrderByDescending(group => group.Count()).First().First();

            int[] freq = new int[101];

            var First = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            var Second = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();

            foreach (var item in First)
            {
                foreach (var item2 in Second)
                {
                    freq[item + item2]++;
                }
            }

            Console.WriteLine(freq.ToList().FindIndex(x => x == freq.ToList().OrderByDescending(x => x).First()));
        }

    }
}
