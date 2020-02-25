using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        //        Bit Removal
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //Template
        //You should implement a function that takes two integer arguments x\ yx y, where both xx and yy are non-negative integers.Return the result of flipping all of the bits of xx that are set to 11 in both xx and yy.
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').Select(x => uint.Parse(x)).ToList();

                var a = tokens[0];
                var b = tokens[1];

                var bitsToFlip = a & b;

                var ans = a ^ bitsToFlip;

                Console.WriteLine(ans);

                //var a = Convert.ToString(tokens[0], 2);
                //var b = Convert.ToString(tokens[1], 2);

                //while (a.Length != b.Length)
                //{
                //    if (a.Length < b.Length)
                //    { a = "0" + a; }
                //    else
                //    {
                //      b = "0" + b;
                //    } 
                //}

                //var ans = String.Join("",a.Select((value, index) => a[index] == b[index] && a[index] == '1' ? '0' : a[index]));

                //int output = Convert.ToInt32(ans, 2);

                //Console.WriteLine(output);
            }
        }
    }
}
