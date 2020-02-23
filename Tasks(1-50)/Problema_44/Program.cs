using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_44
{
    internal class Program
    {
        //        Closest Pair
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //Template
        //You should implement a function that takes as arguments two arrays of NN integers.Find a pair (a, b)(a, b) such that:

        //aa is from the first array
        //bb is from the second array
        //|a-b|∣a−b∣ is minimum
        //Return the minimum possible value of |a-b|∣a−b∣.
        private static void Main(string[] args)
        {
            long n = Int64.Parse(Console.ReadLine());
            List<CustomInt> line1 = Console.ReadLine().Split(' ').Select(x => new CustomInt { value = Int64.Parse(x), Array = 1 }).ToList();
            List<CustomInt> line2 = Console.ReadLine().Split(' ').Select(x => new CustomInt { value = Int64.Parse(x), Array = 2 }).ToList();


            //var ans = from a in line1
            //          join b in line2 on a.value equals b.value
            //          select new { a, b };

            line2.AddRange(line1);

            line2 = line2.OrderBy(x => x.value).ToList();

            long min = long.MaxValue;
            for (int i = 0; i < line2.Count - 1; i++)
            {
                if (line2[i].Array != line2[i + 1].Array)
                {
                    long dif = Math.Abs(line2[i].value - line2[i + 1].value);
                    if(dif==0)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                    if (dif < min)
                    {
                        min = dif;
                    }
                }
            }

            Console.WriteLine(min);
        }
    }

    internal class CustomInt
    {
        public int Array { get; set; }
        public long value { get; set; }
    }
}