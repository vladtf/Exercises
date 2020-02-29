using System;
using System.Linq;

namespace Task_5
{
    class Program
    {
        //        Douchebag Parking
        //Time limit: 1220 ms
        //Memory limit: 258.5 MB

        //Consider a row of N parking spots.For each spot you know whether it's free or not, and you are also given its width. You have a car of width WW. Because you are a douchbag, you afford parking on several consecutive parking spots, as longs as they are all free and their total width is greater or equal than WW.

        //Find the lowest index of a parking spot from a set of consectuive spots where you can park your car.
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

            int n = tokens[0];
            int w = tokens[1];

            for (int i = 1; i <= n; i++)
            {
                tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();
                int index = i;
                int o = tokens[0];
                if (o == 1)
                {
                    int l = tokens[1];
                    while (o == 1 && i < n)
                    {
                        i++;

                        tokens = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToList();

                        o = tokens[0];

                        if (o == 1)
                        {
                            l += tokens[1];
                        }
                    }

                    if (l >= w)
                    {
                        Console.WriteLine(index);
                        return;
                    }
                }
            }

            Console.WriteLine(-1);
        }
    }
}
