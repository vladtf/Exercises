using System;

namespace Problema_19
{
    //    Pokémon Evolution
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //You have recently caught NN Pokémon and you also have MM Pokémon candy bars.You can evolve any of your Pokémon by paying XX candy bars.Alternatively, you can sell any of your Pokémon for a price of YY candy bars. You cannot sell an evolved Pokémon.

    //Compute the maximum number of Pokémon you can evolve.
    internal class Program
    {
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            long n = Int32.Parse(data[0]);
            long m = Int32.Parse(data[1]);
            long x = Int32.Parse(data[2]);
            long y = Int32.Parse(data[3]);

            while (m < n * x)
            {
                n--;
                m += y;
            }

            Console.WriteLine(n);
        }
    }
}