using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Problema_10
{
    internal class Program
    {
        private static int GreatestOddDivisor(int x)
        {
            if (x % 2 == 1) return x;
            for (int i = x / 2; i >= 1; i--)
                if (x % i == 0 && i % 2 == 1)
                {
                    return i;
                }
            return 1;
        }

        private static int DivisorsSum(int x, int y)
        {
            int sum = 0;
            for (int i = x; x <= y; x++)
                sum += GreatestOddDivisor(x);
            return sum;
        }

        private static async Task Main(string[] args)
        {
            string path = "Input.txt";

            string[] lines = File.ReadAllLines(path);

            int T = Int32.Parse(lines[0]);

            var tasks = new List<Task<int>>();

            for (int i = 1; i < lines.Length - 1; i++)
            {
                var task = Task<int>.Run(() =>
                {
                    string line = lines[i];
                    string[] data = line.Split(' ');
                    int A = Int32.Parse(data[0]);
                    int B = Int32.Parse(data[1]);

                    Console.WriteLine("Finished task " + i.ToString());
                    return DivisorsSum(A, B);
                });
                tasks.Add(task);
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}