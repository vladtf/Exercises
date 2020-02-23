using System;
using System.Text;

namespace Problema_14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().ToCharArray();

                Array.Sort(str);

                result.Append(str[0]);
            }

            var ans = result.ToString().ToCharArray();

            Array.Sort(ans);

            Console.WriteLine(new String(ans));
        }
    }
}