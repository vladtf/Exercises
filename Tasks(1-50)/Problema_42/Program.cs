using System;
using System.Linq;

namespace Problema_42
{
    internal class Program
    {
        /*
        Poisoned Food
Time limit: 1220 ms
Memory limit: 258.5 MB

Alex went to a party where there are NN types of food. For each type you know the total number of portions and the number of portions that have been poisoned. Unfortunately, you don't know which portions are safe and which are poisoned.

The rules of the house say you have to eat, so Alex wants to minimize the risk of eating a poisoned portion. Find the type of food that is the safest to eat, if Alex chooses a random portion of that type.
*/

        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int ans = 1; double min = 1;
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').Select(x => Double.Parse(x)).ToList();
                if (tokens[1] / tokens[0] < min)
                {
                    min = tokens[1] / tokens[0];
                    ans = i + 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}