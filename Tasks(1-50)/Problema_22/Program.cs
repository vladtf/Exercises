using System;
using System.Linq;

namespace Problema_22
{
    //  Attack and Speed
    // Time limit: 1220 ms
    // Memory limit: 130.5 MB

    // You are playing a game where your character has two main characteristics : attack and speed.Your current attack level is AA and the current speed level is SS.

    //You also have KK dollars.Each dollar can be used to either increase the attack by XX, or the speed by YY.Your goal is to spend all the dollars and bring the attack and speed at the same level.
    internal class Program
    {
        private static void Main(string[] args)
        {
            long[] token = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long A = token[0];
            long S = token[1];
            long K = token[2];
            long X = token[3];
            long Y = token[4];

            if ((S + K * Y - A) % (X + Y) == 0)
            {
                Console.WriteLine((S + K * Y - A) / (X + Y));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}