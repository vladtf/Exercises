using System;

namespace Problema_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pair pair = new Pair();

            try
            {
                Console.Write("a = ");
                pair.a = int.Parse(Console.ReadLine());

                Console.Write("a = ");
                pair.b = int.Parse(Console.ReadLine());

                pair.Afisare();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }

    internal class Pair
    {
        public int a;
        public int b;

        public int Suma()
        {
            int suma = 0;

            for (int i = a; i <= b; i++)
                if (Prim(i) == 0)
                    suma += i;
            return suma;
        }

        public int Prim(int x)
        {
            if (x < 2) return 0;
            if (x == 2) return 1;
            if (x % 2 == 0) return 0;
            for (int i = 3; i * i <= x; i++)
                if (x % i == 0)
                    return 0;
            return 1;
        }

        public void Afisare()
        {
            Console.WriteLine($"Suma intregilor neprimi dintre {a} si {b} este = " + Suma());
        }
    }
}