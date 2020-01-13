using System;

namespace Problema_2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Pereche pereche = new Pereche();

            string s = "";

            while (s != "n")
            {
                Console.Write("x = ");
                s = Console.ReadLine();

                try
                {
                    if (s != "n")
                    {
                        pereche.x = int.Parse(s);

                        Console.Write("y = ");
                        s = Console.ReadLine();

                        pereche.y = int.Parse(s);

                        pereche.Afisare();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    public class Pereche
    {
        public int x;
        public int y;

        public int Suma()
        {
            return x + y;
        }

        public void Afisare()
        {
            Console.WriteLine("Suma x si y este = " + Suma());
        }
    }
}