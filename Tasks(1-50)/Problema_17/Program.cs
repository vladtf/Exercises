using System;

namespace Problema_17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            int n = Int32.Parse(data[0]);
            int k = Int32.Parse(data[1]);

            line = Console.ReadLine();
            data = line.Split(' ');

            int[] values = Array.ConvertAll(data, Int32.Parse);

            Array.Sort(values);

            int minVol = 0;

            for (int i = 0; i < k; i++)
            {
                minVol += values[i];
            }

            if (minVol % 100 == 0)
            {
                Console.WriteLine(minVol / 100);
            }
            else
            {
                Console.WriteLine(((minVol - minVol % 100 + 100) / 100).ToString());
            }
        }
    }
}