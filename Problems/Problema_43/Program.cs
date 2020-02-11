using System;
using System.Linq;

namespace Problema_43
{
    class Program
    {
//        Anomalies
//Time limit: 1220 ms
//Memory limit: 258.5 MB

//You are given an array AA of NN integers.An anomaly is a number for which the absolute difference between it and all the other numbers in the array is greater than KK.Find the number of anomalies.

        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            int n = tokens[0];
            int k = tokens[1];

            tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                bool ok = true;
                for (int j = 0; j < n && ok; j++)
                {
                    if (Math.Abs(tokens[i] - tokens[j]) <= k && j!=i)
                    {
                        ok = false;
                    }
                }
                if (ok)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
