using System;
using System.Collections.Generic;

namespace Problema
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Obiect> words = new List<Obiect>();
            string s = "";
            while (s != "n")
            {
                Obiect obiect;

                Console.Write("string s = ");
                s = Console.ReadLine();

                if (s != "n")
                {
                    int a = 0, b = 0;
                    Console.Write("int a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("int b = ");
                    b = int.Parse(Console.ReadLine());

                    obiect = new Obiect(a, b);

                    obiect.SetString(s);

                    words.Add(obiect);
                }
            }

            foreach (Obiect obiect in words)
            {
                Console.WriteLine(obiect.Str + "  de lungime  " + obiect.Str.Length.ToString()
                    + "  si suma = " + (obiect.A + obiect.B).ToString());
                if (Obiect.Prime(obiect.A) && Obiect.Prime(obiect.B))
                {
                    Console.WriteLine(obiect.A.ToString() + " si " + obiect.B.ToString() + " sunt prime; suma = " + (obiect.A + obiect.B).ToString());
                }
            }

            Console.Write("Citeste caracaterul s = ");
            s = Console.ReadLine();
            Console.Write("Sirurile care nu contin " + s + " sunt : ");
            foreach (Obiect obiect in words)
            {
                if (!obiect.Str.Contains(s))
                {
                    Console.Write(obiect.Str + ", ");
                }
            }
            Console.ReadLine();
        }
    }

    public class Obiect
    {
        public Obiect(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A;
        public int B;

        public string Str;

        public void SetString(string str)
        {
            Str = str;
        }

        public static bool Prime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
}