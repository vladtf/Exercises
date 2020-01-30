using System;

namespace Problema_25
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Problema_24
    {

        class WordsList
        {
            //salveaza lista de cuvinte din sir
            public List<string> Words;
            //salveaza sirul de cuvinte citit ( linia din consola )
            public string Line;

            //salveaza cuvintele din sir cu lungimea maxima
            public List<string> CuvinteDeLungimeMaxime = new List<string>();
            public void Citire()
            {
                Console.Write("Introdu sirul: ");
                Line = Console.ReadLine();

                //Desparte cuvintele din sir unde gaseste spatiu si le converteste intr-o lista de cuvine
                Words = Line.Split(' ').ToList();

                ////Cauta lungimea maxima dintre cuvintele din sir
                //int lungimeMaxima = 0;
                //foreach (string word in Words)
                //{
                //    if (word.Length > lungimeMaxima)
                //    {
                //        lungimeMaxima = word.Length;
                //    }
                //}

                ////Cauta cuvintele de lungime maxima si le salveaza intr-o lista
                //foreach (string word in Words)
                //{
                //    if (word.Length == lungimeMaxima)
                //    {
                //        CuvinteDeLungimeMaxime.Add(word);
                //    }
                //}

                var items = Words.OrderByDescending(x => x.Length).ToList();

                CuvinteDeLungimeMaxime = items.Where(x => x.Length == items.FirstOrDefault().Length).ToList();


            }

        }

        internal class Program
        {
           static void Main(string[] args)
            {
                List<WordsList> lista = new List<WordsList>();
                List<string> cuvinteCuLungimeaMaxima = new List<string>();
                char ch = '1';

                while (ch != 'n')
                {
                    WordsList obj = new WordsList();
                    obj.Citire();

                    lista.Add(obj);

                    Console.WriteLine("Apasati n pt a  iesi!");
                    ch = char.Parse(Console.ReadLine());
                }

                Console.Write("Introdu caracterul:");
                char caracter = char.Parse(Console.ReadLine());

                //verifica daca a fost gasit macar un sir care sa inceapa cu caracterul setat
                bool ok = false;
                Console.WriteLine("Sirule care au cuvinte ce incep cu caracterul {0} sunt: \n", caracter);

                //afiseaza sirurile care contin cel putin un cuvant care incepe cu caracterul setat
                lista.Select(x => x.Words).Where(x => !String.IsNullOrWhiteSpace(x.Find(x => x.StartsWith(caracter.ToString())))).
                    Select(x => String.Join(" ", x)).ToList().ForEach(x => { Console.WriteLine(x); });

                //Afiseaza toate cuvintele de lungime maxima
                Console.WriteLine(String.Join(" ", lista.Select(x => String.Join(" ", x.CuvinteDeLungimeMaxime.ToArray())).ToArray()));

                Console.ReadLine();

                //foreach (var item in lista)
                //{
                //    foreach (var cuvant in item.Words)
                //    {
                //        if (cuvant[0] == caracter)
                //        {
                //            ok = true;
                //            Console.WriteLine(item.Line);
                //            break;
                //        }
                //    }
                //}

                //var cuvinte = lista.Select(x => x.Words.Where(o => o.StartsWith(caracter.ToString())).ToList()).ToList();

                //if (!ok)
                //{
                //    Console.WriteLine("Nu a fost gasit nici-un sir corespunzator");
                //}


                ////Trece prin toate obiectele listei
                //foreach (var item in lista)
                //{
                //    //Addauga in lista de cuvinte cu lungime maxima toate cuvintele de lungime maxima corespunaztor
                //    //fiecarui obiect din lista
                //    foreach (string word in item.CuvinteDeLungimeMaxime)
                //    {
                //        cuvinteCuLungimeaMaxima.Add(word);
                //    }
                //}
                //Console.WriteLine();
                //Console.Write("Cuvintele cu lungime maxima sunt :");
                //foreach (string word in cuvinteCuLungimeaMaxima)
                //{
                //    Console.Write(word);
                //    Console.Write(" ");
                //}
            }
        }
    }

}
