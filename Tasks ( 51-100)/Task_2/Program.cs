using System;
using System.Linq;

namespace Task_2
{
    class Program
    {
        //        Least Significant Bit
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //Template
        //You should implement a function that takes as argument a positive integer xx and returns its least significant bit.More precisely you should return another integer whose binary representation contains a single bit set to 11, and that bit is the least significant one that is also set to 11 in xx.
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = Int32.Parse(Console.ReadLine());

                int noLSB = x & (x - 1);

                int ans = x ^ noLSB;

                Console.WriteLine(ans);

                //string x = Convert.ToString(Int32.Parse(Console.ReadLine()), 2);

                //var ans = x.Length - x.LastIndexOf('1') - 1;

                //Console.WriteLine(1 << ans);
            }
        }
    }
}
