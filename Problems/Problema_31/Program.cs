using System;
using System.Linq;

namespace Problema_31
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine())-101;
            Console.WriteLine(Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).Where(x => { if (x > n) { n = x; return true; } return false; }).Count());

            //int count = 0;
            //Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList().ForEach(x => { if (x > n) { n = x; count++; } });
            //Console.WriteLine(count);
        }
    }
}
