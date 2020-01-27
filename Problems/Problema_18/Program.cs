using System;

namespace Problema_18
{
    //    Donkey Paradox
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //On a field represented as a matrix of NN rows and MM columns there is a donkey and two haystacks.

    //The donkey is really hungry and he wants to get to a haystack as fast as possible.He can walk in four directions: up, down, left or right.The paradox of the donkey is that if the two haystacks are equally close to him he won't be able to decide which one to choose and he will starve to death.

    //You are given the cells of the haystackes, but you don't know where the donkey is. Compute the number of cells where the donkey will starve if he's there.
    internal class Program
    {
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            line = Console.ReadLine();
            data = line.Split(' ');

            int x1 = Int32.Parse(data[0]);
            int y1 = Int32.Parse(data[1]);

            line = Console.ReadLine();
            data = line.Split(' ');

            int x2 = Int32.Parse(data[0]);
            int y2 = Int32.Parse(data[1]);

            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (Math.Abs(i - x1) + Math.Abs(j - y1) == Math.Abs(i - x2) + Math.Abs(j - y2))
                        ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}