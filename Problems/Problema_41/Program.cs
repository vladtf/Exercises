using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_41
{
    class Program
    {
//        Reversed Number
//Time limit: 1220 ms
//Memory limit: 258.5 MB

//You are given a number XX.

//Print 1 if the number XX is strictly less than the number formed by reversing XX's digits in base 1010, or 0 otherwise.
        static void Main(string[] args)
        {
            var reversed = Console.ReadLine().ToCharArray().ToList();
            var init = new List<char>(reversed);
            reversed.Reverse();

            bool ok = true;
            for (int i = 0; i < reversed.Count(); i++)
            {
                if (init[i] != reversed[i])
                {
                    if (init[i] < reversed[i])
                    {
                        ok = false;
                    }
                    else
                    {
                        ok = true;
                    }
                }
            }

            if (ok)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
