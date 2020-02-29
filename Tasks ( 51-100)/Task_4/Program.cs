using System;
using System.Linq;
using System.Text;

namespace Task_4
{
    class Program
    {
        //        Look and Say
        //Time limit: 1220 ms
        //Memory limit: 130.5 MB

        //Template
        //You should implement a function that finds the NN-th element in the Look-and-say sequence:

        //1, 11, 21, 1211, 111221, 312211, 13112221, 11132132111,11,21,1211,111221,312211,13112221,1113213211
        //To generate a member of the sequence from the previous member, read off the digits of the previous member, counting the number of digits in groups of the same digit.For example:

        //11 is read off as "one 11" or 1111.
        //1111 is read off as "two 11s" or 2121.
        //2121 is read off as "one 22, then one 11" or 12111211.
        //12111211 is read off as "one 11, one 22, then two 11s" or 111221111221.
        //111221111221 is read off as "three 11s, two 22s, then one 11" or 312211312211.

        private static string TransformString(string initial)
        {
            //string output = String.Join("",initial.GroupBy(x => x).Select(x=>x.First()));

            StringBuilder output = new StringBuilder();

            int index = 0;
            while (index < initial.Length)
            {
                int count = 1;
                while (index < initial.Length - 1 && initial[index] == initial[index + 1])
                {
                    index++;
                    count++;
                }

                output.Append(count.ToString() + initial[index]);

                index++;
            }

            return output.ToString();
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            string ans = "1";

            for (int i = 0; i < n - 1; i++)
            {
                ans = TransformString(ans);
            }

            Console.WriteLine(ans);
        }
    }
}
