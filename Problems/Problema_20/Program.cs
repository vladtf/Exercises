using System;

namespace Problema_20
{
    //    Balanced Number
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //You are given a positive number NN.We say the frequency of cc is equal to the number of digits of NN equal to cc.

    //NN is balanced if the frequency of all cc (0 \leq c \leq 90≤c≤9) is the same.Decide whether NN is balanced or not.
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] frec = new int[11];

            for (int i = 0; i < input.Length; i++)
            {
                int nr = input[i] - '0';
                frec[nr]++;
            }

            for (int i = 1; i < 10; i++)
            {
                if (frec[i] != frec[0])
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }
    }
}