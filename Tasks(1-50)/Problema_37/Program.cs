using System;
using System.Linq;

namespace Problema_37
{
    class Program
    {
//        Replace A
//Time limit: 1220 ms
//Memory limit: 258.5 MB

//You are given a string SS containing only letters A or B.You can take any two adjacent As and replace them by a single A.You perform operations as long as possible.Print the final string.
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.ReadLine().Split('B').Select(x=>x.First()).Select(x => "AB").Aggregate((current, next) => current + next)); 

            //var line = Console.ReadLine().Select(x => x.ToString()).ToArray();
            //string ans = line.Aggregate((current, value) =>
            //{
            //    if (next != null)
            //    {
            //        if (value == "B")
            //        {
            //            return value + "";
            //        }
            //        if (value == next && value == "A")
            //        {
            //            return "";
            //        }
            //        return value + next;
            //    }
            //    return "";
            //});

            var line = Console.ReadLine().ToCharArray();
            string ans = "";
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] == 'B')
                {
                    ans += 'B';
                }
                else if (line[i] != line[i + 1] && line[i] == 'A')
                {
                    ans += 'A';
                }
            }
            ans += line.Last();
            Console.WriteLine(ans);
        }
    }
}
