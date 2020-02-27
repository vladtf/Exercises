using System;
using System.Linq;

namespace Task_3
{
    //    Digit Holes
    //Time limit: 1220 ms
    //Memory limit: 258.5 MB

    //When writing digits, some of them are considered to have holes: 00, 66 and 99 have one hole, while 88 has two holes.The other digits don't have any holes.

    //Given two integers AA and BB, find a value in the interval[A, B][A, B] that has the maximum total number of holes in its digits.If the solution is not unique, print the smallest one.
    class Program
    {
        private static int GetNrOfHoles(int x)
        {
            int count = 0;
            if (x == 0)
            {
                return 1;
            }
            while (x != 0)
            {
                int lastD = x % 10;
                if (lastD == 6 || lastD == 0 || lastD == 9)
                {
                    count++;
                }
                if (lastD == 8)
                {
                    count += 2;
                }

                x /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();

            int a = tokens[0];
            int b = tokens[1];

            int maxHoles = GetNrOfHoles(a);
            int ans = a;
            for (int i = a; i <= b; i++)
            {
                if (GetNrOfHoles(i) > maxHoles)
                {
                    ans = i;
                    maxHoles = GetNrOfHoles(i);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
