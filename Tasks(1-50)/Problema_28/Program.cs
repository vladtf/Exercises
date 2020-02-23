using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //creaza obiectul nou
            Numar obiect = new Numar();

            string str = "";

            //Citeste obiecte pana cand nu este introdus caracaterul n
            while (str != "n")
            {
                //Citeste obiectul
                obiect.Citire();

                //afiseaza x la puterea y din obiect
                obiect.Afisare();

                //citeste caracterul, dacca este "n" atunci va iesi din for
                Console.Write("Scrie n pentru a iesi : ");
                str = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
    class Numar
    {
        public int x;
        public int y;


        //citeste obiectul
        public void Citire()
        {
            Console.Write("Citeste x : ");
            x = int.Parse(Console.ReadLine()); //transform caracterul citit in intreg
            Console.Write("Citeste y : ");
            y = int.Parse(Console.ReadLine()); //transform caracterul citit in intreg
        }

        //Afiseaza x la puterea y
        public void Afisare()
        {
            Console.WriteLine("X la puterea Y este : " + xPutereY().ToString());
        }

        public int xPutereY()
        {
            // x la puterea 0 este 1
            int result = 1;

            // inumulteste rezultatul cu x de y ori -> x*x*x*x*...*x = x la puterea y
            for (int i = 1; i <= y; i++)
            {
                result = result * x;
            }

            //returneaza x la puterea y
            return result;
        }

    }

}
