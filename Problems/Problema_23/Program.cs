using System;
using System.Linq;

namespace Problema_23
{
    class Program
    {
//        Erase Value
//Time limit: 1220 ms
//Memory limit: 130.5 MB

//You are given an array AA of NN positive integers.You can choose any positive value xx and erase all the elements of AA equal to xx.In the end you want the sum of the elements of the array to be as small as possible.
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] tokens = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            int[] freq = new int[n+1];

            int sum = 0;

            foreach (var item in tokens)
            {
                sum += item;
                freq[item]++;
            }

            int maxValue = 0;

            for (int i = 0; i <= n; i++)
            {
                if(freq[i]*i>maxValue)
                {
                    maxValue = freq[i] * i;
                }
            }

            Console.WriteLine(sum-maxValue);
        }
    }
}
