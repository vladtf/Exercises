using System;

namespace Problema_16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            string[] data = line.Split(' ');

            int[] vec = Array.ConvertAll(data, Int32.Parse);

            int[] auxVec = new int[vec.Length];

            auxVec[0] = 1;

            for (int i = 0; i < n - 1; i++)
            {
                if (vec[i] > vec[i + 1])
                {
                    auxVec[i + 1] = auxVec[i] + 1;
                }
                else
                {
                    auxVec[i + 1] = 1;
                    int max = auxVec[i];
                    for (int j = 1; j <= max; j++)
                    {
                        Console.Write(max.ToString() + " ");
                    }
                }
            }
            for (int i = 1; i <= auxVec[auxVec.Length - 1]; i++)
            {
                Console.Write(auxVec[auxVec.Length - 1].ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}