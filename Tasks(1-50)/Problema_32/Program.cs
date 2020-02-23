using System;
using System.Linq;

namespace Problema_32
{
    class Program
    {
        //        Four X-tremes
        //   Time limit: 1220 ms
        //   Memory limit: 130.5 MB

        //   Template
        //You should implement a function that takes as arguments four integers.Return the maximum difference between any two integers.
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(x=>Int32.Parse(x)).OrderBy(x=>x).ToList();
            Console.WriteLine(Math.Abs(line.First()-line.Last()));
        }
    }
}
