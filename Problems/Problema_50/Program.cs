using System;
using System.Linq;

namespace Problema_50
{
    //    Bit Count
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //Template
    //You are given an integer NN that can be represented on 3232 bits.Implement a function that counts the numbers of bits set to 11 in NN's binary representation.
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Int32.Parse(Console.ReadLine().Trim());

            //int ans = 0;

            //while (n > 0)
            //{
            //    if (n % 2 == 1)
            //    {
            //        ans++;
            //    }
            //    n /= 2;
            //}

            //Console.WriteLine(ans);

            Console.WriteLine(Convert.ToString(Int32.Parse(Console.ReadLine().Trim()),2).Where(x=>x=='1').Count());
        }
    }
}
