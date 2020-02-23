using System;
using System.Linq;

namespace Problema_39
{
    class Program
    {
//        Grade System
//Time limit: 1220 ms
//Memory limit: 258.5 MB

//Considering a set of NN grades, an interesting grading system consists of removing one of the minimum and one of the maximum values, and then finding the arithmetic mean of the rest of the N-2N−2 grades.

//Given a set of NN grades, print the result of the grading system.
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var tokens = Console.ReadLine().Split(' ').Select(x=> Int32.Parse(x)).ToList();
            var max = tokens.Max();
            var min = tokens.Min();
            var ans = (int)((tokens.Sum() - min - max) / (n - 2));
            Console.WriteLine(ans);
        }
    }
}
