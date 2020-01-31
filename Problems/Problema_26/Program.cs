using System;

namespace Problema_26
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToCharArray();
            char[] ciphr = Console.ReadLine().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = ciphr[str[i] - 'a'];
            }

            Console.WriteLine(new string(str));
        }
    }
}
