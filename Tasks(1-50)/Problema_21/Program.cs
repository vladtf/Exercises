using System;

namespace Problema_21
{
    //    Matrix Rotations
    //Time limit: 1220 ms
    //Memory limit: 130.5 MB

    //You are given a square matrix AA of size NN.The cells of the matrix are either 00 or 11. Consider the three matrices that are obtained by rotating AA by 90^{\circ
    //}90
    //​∘
    //​​ , by 180^{\circ}180
    //​∘
    //​​ , and by 270^{\circ}270
    //​∘
    //​​ , respectively.
    internal class Program
    {
        private static void Rotate(int[,] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = A[n - j - 1, i] | A[i, j];
                }
            }
        }

        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[,] A = new int[n + 1, n + 1];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] token = line.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Int32.Parse(token[j]);
                }
            }

            Rotate(A, n);
            Rotate(A, n);
            Rotate(A, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}