using System;

namespace Problema_8
{
    internal class Program
    {
   //     N children are playing a game.They are split in two teams, RR of them are in the red team and N-RN−R are in the blue team.

   //You also know that exactly KK of them will switch teams.Find the minimum and maximum possible number of children in the red team after they all switch teams.
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            int max = 0;
            int min = 0;

            int N = int.Parse(data[0]);
            int R = int.Parse(data[1]);
            int K = int.Parse(data[2]);
            int B = N - R;

            int i = K;
            int r = R;
            int b = B;

            while (i > 0)
            {
                if (b > 0)
                {
                    r++; b--; i--;
                }
                else
                {
                    while(i>0)
                    {
                        r--; b++; i--;
                    }
                }
            }

            max = r;

            i = K;
            r = R;
            b = B;

            while (i > 0)
            {
                if (r > 0)
                {
                    r--; b++; i--;
                }
                else
                {
                    while (i > 0)
                    {
                        r++; b--; i--;
                    }
                }
            }

            min = r;

            Console.WriteLine(min.ToString() +" "+ max.ToString());

            Console.ReadLine();
        }
    }
}