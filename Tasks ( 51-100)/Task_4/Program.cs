using System;
using System.Linq;
using System.Text;

namespace Task_4
{
    class Program
    {
        private static string TransformString(string initial)
        {
            //string output = String.Join("",initial.GroupBy(x => x).Select(x=>x.First()));

            StringBuilder output = new StringBuilder();

            int index = 0;
            while (index < initial.Length)
            {
                int count = 1;
                while (index < initial.Length && initial[index] == initial[index+1])
                {
                    index++;
                    count++;
                }

                output.Append(count.ToString()+initial[index]);

                index++;
            }

            return output.ToString();
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            string ans = "1";

            for (int i = 0; i < n; i++)
            {
                ans = TransformString(ans);
            }

            Console.WriteLine(ans);
         }
    }
}
