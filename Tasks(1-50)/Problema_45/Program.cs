using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_45
{
    class Program
    {
        //        Nested Segments
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You are given NN segments.For each segment ii you know two integers l_il
        //​i
        //​​  and r_ir
        //​i
        //​​ , representing the left and the right ends of the segment.

        //A segment ii is nested inside segment jj if l_j<l_il
        //​j
        //​​ <l
        //​i
        //​​  and r_i<r_jr
        //​i
        //​​ <r
        //​j
        //​​ . Find the number of segments that are nested inside at least one other segment.

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var items = new List<(int l, int r)>();

            for (int i = 0; i < n; i++)
            {
                var line = (from s in Console.ReadLine().Split(' ').ToList()
                            select Int32.Parse(s)).ToList();

                items.Add((l: line[0], r: line[1]));
            }

            var ans = (from a in items
                       from b in items
                       where a.l > b.l && a.r < b.r
                       select new { a.l, a.r }).ToList();


            var groups = ans.GroupBy(x => x).ToList();
            Console.WriteLine(groups.Count());
        }
    }
}
