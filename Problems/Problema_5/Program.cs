using System;
using System.Collections.Generic;

namespace Problema_5
{
    internal class Program
    {

        //Functia care verifica daca un numar este prim
        public static int Prim(int x)
        {
            if (x < 2) return 0;
            if (x == 2) return 1;
            if (x % 2 == 0) return 0;
            for (int i = 3; i * i <= x; i++)
                if (x % i == 0)
                    return 0;
            return 1;
        }

        //Calculeaza suma numerelor prime dintr-o lista de numere intregi
        public static int Suma(List<int> v)
        {
            int sum = 0;

            foreach (int x in v)
            {
                //Verifica daca numarul este prime
                if (Prim(x) == 1)
                {
                    //Daca numarul este prim atunci il aduna la suma totatal
                    sum = sum + x;

                    //Afiseaza suma curenta
                    Console.WriteLine("Suma curenta este : "+sum);
                }
            }

            return sum;
        }

        //Returneaza cifra maxima a unui numar
        public static int CifraMaxima(int x)
        {
            int max = 0;


            while(x>0)
            {
                //Daca ultima cifra a numarului este mai mare decat maxim atunci il inlocuieste
                if (x % 10 > max) max = x % 10;
                //Elimineaza ultima cifra
                x = x / 10;
            }

            return max;
        }

        private static void Main(string[] args)
        {
            //Creeaza o lista ( vector ) de numere inregi
            List<int> v = new List<int>();

            string s = "";

            //Citeste pana cand este introdus caracterul "n";
            while (s != "n")
            {
                Console.Write("Citeste numarul : ");
                s = Console.ReadLine();

                //Daca caracterul introdus nu este "n" il adauga in lista
                if (s != "n")
                {
                    //Adauga in lista intregul ( converteste un string in int )
                    v.Add(int.Parse(s));
                }
            }

            //Contorul numerelor prime
            int nr = 0;

            Console.Write("Numerele prime sunt : ");

            //Trece prin toate elementele din lista v ( v[0] , v[1] , v[2] ) ...)
            foreach (int x in v)
            {
                //Daca numarul este prim atunci il afiseaza
                if (Prim(x) == 1)
                {
                    Console.Write(x.ToString() + " ");

                    //Mareste contorul numerelor prime
                    nr++;
                }
            }
            Console.WriteLine();

            //Afiseara numarului de numere prime
            Console.WriteLine("Numarul de intregi primi este : " + nr.ToString());


            //Afiseaza suma numerelor prim apeland metod Suma
            Console.WriteLine("Suma intregilor primi este : " + Suma(v));

            int sum = 0;

            //Insumeaza cifra maxima a fiecarui numar din lista
            foreach (int  x in v)
            {
                sum = sum + CifraMaxima(x);
            }

            //Afiseaza suma cifrelor maxime
            Console.WriteLine("Suma cifrelor maxime este : " + sum);

            Console.ReadLine();
        }
    }
}