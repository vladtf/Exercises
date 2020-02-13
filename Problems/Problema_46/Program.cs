using System;
using System.Linq;
using System.Numerics;

namespace Problema_46
{
    internal class Program
    {
        //        Banknotes
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //Template
        //You have an unlimited amount of banknotes worth AA or BB dollars(A \neq BA≠B). You want to pay a total of SS dollars using exactly NN banknotes.You should implement a function that returns the number of banknotes worth AA dollars you need.If there is no solution return -1−1.
        private static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(x => Int64.Parse(x)).ToList();

            //long a = Math.Max(line[0], line[1]);
            //long b = Math.Min(line[0], line[1]);
            var a = line[0];
            var b = line[1];
            var s = line[2];
            var n = line[3];

            //double x = (s - n * b) / (a - b);
            //Console.WriteLine((s - n * b) % (a - b) == 0 ? (long)(s - n * b) / (a - b) : -1);

            if ((s - n * b) % (a - b) == 0)
            {
                Console.WriteLine(((s - n * b) / (a - b)).ToString());
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}