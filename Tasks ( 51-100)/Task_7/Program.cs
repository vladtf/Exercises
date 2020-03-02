using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_7
{
    internal class Program
    {
        //        Milk and Bread
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //You have a new task: buy milk and bread.

        //You are given three integers representing the coordinates of the milk shop, the bread shop, and yours on the x-axis.Find the minimum distance you need to travel to visit both the milk shop and the bread shop, in any order.
        private static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Select(x => Int32.Parse(x)).ToList();

            int milk = tokens[0] < tokens[1] ? tokens[0] : tokens[1];
            int bread = tokens[0] > tokens[1] ? tokens[0] : tokens[1];
            int me = tokens[2];

            if (me < milk)
            {
                Console.WriteLine(bread - me);
            }
            else if (me > bread)
            {
                Console.WriteLine(me - milk + 1);
            }
            else
            {
                Console.WriteLine(bread - milk + Math.Min(bread - me, me - milk));
            }
        }
    }
}