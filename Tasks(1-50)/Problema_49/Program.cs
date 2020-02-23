using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_49
{
    class Program
    {
        //        Flip Game
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //You are given a binary matrix of NN rows and MM columns.You can perform the following type of operations:

        //Choose a row/column and change the state of each element.If the elment is 00 change it to 11, and if it's 11 change it to 00.
        //You are allowed to perform an unlimited number of operations. In the end you interpret each row as the binary representation of a number, where the first column is associated with the most significant bit. You should maximize the sum of all the NN numbers.
        static void Main(string[] args)
        {

            var line = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
            int n = line[0];
            int m = line[1];

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Trim().Split(' ').Select(x => Int32.Parse(x)).ToList();
                matrix.Add(tokens);

                if (matrix[i][0] == 0)
                {
                    matrix[i] = matrix[i].Select(x => x == 0 ? 1 : 0).ToList();
                }

            }

            List<int> columnsToFlip = new List<int>();

            for (int i = 1; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[j][i];
                }

                if (sum <= n / 2)
                {
                    columnsToFlip.Add(i);
                }
            }

            long ans = 0;
            foreach (var row in matrix)
            {
                foreach (int item in columnsToFlip)
                {
                    row[item] = row[item] == 0 ? 1 : 0;
                }

                ans += Convert.ToInt64(String.Join("", row.Select(x => x.ToString())), 2);
            }

            Console.WriteLine(ans);

        }
    }
}
