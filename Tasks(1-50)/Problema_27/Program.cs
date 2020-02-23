using System;
using System.Linq;

namespace Problema_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            tokens[1] += Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray().Sum();
            tokens[2] += Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray().Sum();

            if (tokens[1] > tokens[2])
            {
                Console.WriteLine(1);
            }
            else if (tokens[1] == tokens[2])
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(2);
            }

        }

    }
}
