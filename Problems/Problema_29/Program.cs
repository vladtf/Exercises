using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomObject> lista = new List<CustomObject>();
            Console.Write("Citeste sir de caractere ('n' pentru a iesi) :");
            string str = Console.ReadLine();
            while (str.Length >= 5)
            {
                CustomObject obiect = new CustomObject();
                obiect.PrelucrareSir(str);
                Console.WriteLine();
                Console.Write("Citeste al doilea sir de caracter ('n' pentru a iesi) : ");
                obiect.Citire();
                if (obiect.sir1 == "n")
                {
                    lista.Add(obiect);
                    break;
                }

                lista.Add(obiect);

                Console.Write("Citeste sir de caractere ('n' pentru a iesi) :");
                str = Console.ReadLine();
                if (str == "n")
                    break;
            }

            foreach (var item in lista)
            {
                Console.WriteLine("Sirul initial este : " + item.sirInitial);
                Console.WriteLine("Sirul prelucrate este : " + item.str);
                Console.Write("Structura de date din sir :");
                foreach (var numar in item.Numbers)
                {
                    Console.Write(numar);
                    Console.Write(" , ");
                }

            }

            Console.ReadKey();
        }
    }

    public class CustomObject
    {
        public string str = "";
        public string sirInitial = "";

        public List<int> Numbers = new List<int>();

        public void PrelucrareSir(string s)
        {
            sirInitial = s;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || s[i] == ' ')
                    str += s[i];
                else
                {
                    string x = "";
                    while (s[i] >= '1' && s[i] <= '9')
                    {
                        x += s[i];
                        i++;
                        if (i >= s.Length)
                            break;
                        if (!(s[i] >= '1' && s[i] <= '9'))
                            break;
                    }
                    Numbers.Add(int.Parse(x));
                    i--;
                }
            }
        }

        public string sir1 = "";
        public int[] frecventa = new int[32];
        public void Citire()
        {
            sir1 = Console.ReadLine();

            for (int i = 0; i < sir1.Length; i++)
            {
                frecventa[(int)(sir1[i] - 'a')]++;
            }
        }

    }

}
