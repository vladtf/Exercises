using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_47
{
    class Program
    {
        //        Maximize Profit
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You have an initial amount of money SS.There are QQ deals you can make to increase your sum.Each deal ii will either add a constant number KK, or it can increase your current amount by a percentage P_iP
        //​i
        //​​ .

        //You can apply the deals in any order, and for each of them you can choose wether it will add a constant value or a percentage.Maximize the final value of SS.
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            double s = line[0];
            int q = line[1];
            int k = line[2];

            List<int> p = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).OrderBy(x => x).ToList();

            foreach (var item in p)
            {
                if ((item * s) / 100 > k)
                {
                    s += (item * s) / 100;
                }
                else
                {
                    s += k;
                }
            }

            Console.WriteLine($"{s:F9}");

        }
    }
}
