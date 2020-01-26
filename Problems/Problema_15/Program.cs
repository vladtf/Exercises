using System;

namespace Problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            int n = Int32.Parse(data[0]);
            int k = Int32.Parse(data[1]);

            line = Console.ReadLine();
            data = line.Split(' ');

            int[] vec = new int[1006];

            for (int i = 0; i < n; i++)
            {
                int x = Int32.Parse(data[i]);
                vec[x]++;
            }

            int ans = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (vec[i]>=k)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans.ToString());

            Console.ReadLine();
        }
    }
}
