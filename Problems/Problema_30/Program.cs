using System;

namespace Problema_30
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int distX = 0;
            int distY = 0;
            for (int i = 0; i < line.Length; i++)
            {
                switch (line[i])
                {
                    case 'N': 
                        distY++;
                        break;
                    case 'S':
                        distY--;
                        break;
                    case 'E':
                        distX++;
                        break;
                    case 'W':
                        distX--;
                        break;
                }
            }
            Console.WriteLine(Math.Abs(distX)+Math.Abs(distY));
        }
    }
}
