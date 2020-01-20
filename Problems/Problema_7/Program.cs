using System;

namespace Propblema_7
{
    internal class Program
    {
        //public static int count_div(int x)
        //{
        //    int rez = 0;

        //    for (int i = 1; i <= x; i++)
        //    {
        //        if (x % i == 0)
        //            rez++;
        //    }
        //    return rez;
        //}

        //private static void Main(string[] args)
        //{
        //    string line = Console.ReadLine();
        //    line = line.TrimEnd().TrimStart();

        //    string[] data = line.Split(' ');

        //    int A = int.Parse(data[0]);
        //    int B = int.Parse(data[1]);

        //    int count = 0;

        //    for (int i = A; i <= B; i++)
        //    {
        //        if (count_div(i) % 2 == 1)
        //            count++;
        //    }

        //    Console.WriteLine(count);

        //    Console.ReadLine();
        //}

        static int f(int x, int y)
        {
            int r = x % y;
            while (r != 0)
            {
                r = x % y;
                x = y;
                y = r;
            }
            return x;
        }
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            //line = line.TrimEnd().TrimStart();
            string[] data = line.Split(' ');

            int A = int.Parse(data[0]);
            int B = int.Parse(data[1]);

            Console.WriteLine(f(A, B).ToString());

            Console.ReadLine();
        }
    }
}