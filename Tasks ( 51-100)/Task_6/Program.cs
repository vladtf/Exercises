using System;
using System.Linq;

namespace Task_6
{
    class Program
    {
        //        Three Equal
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You are given an array AA of NN integers between 00 and 22. With cost 11 you can apply the following operation A_i = ((A_i + 1)\ \% \ 3)A
        //​i
        //​​ =((A
        //​i
        //​​ +1) % 3).

        //Find the minimum cost to make all elements equal.
        private static int GetCost(int from, int to)
        {
            if (from == to)
            {
                return 0;
            }
            if (from < to)
            {
                return to - from;
            }
            return 3 + to - from;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

            var ans = tokens.Select(x => GetCost(x, 0)).Sum();
            ans = Math.Min(ans, tokens.Select(x => GetCost(x, 1)).Sum());
            ans = Math.Min(ans, tokens.Select(x => GetCost(x, 2)).Sum());

            Console.WriteLine(ans);
        }
    }
}
