using System;

namespace Problema_11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] Lsize = new int[105];
            int[] Rsize = new int[105];

            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine();
                string[] data = line.Split(' ');

                var size = Int32.Parse(data[0]);

                if (data[1] == "L")
                {
                    Lsize[size]++;
                }
                else
                {
                    Rsize[size]++;
                }
            }

            int rez = 0;

            for (int i = 0; i <= 100; i++)
            {
                rez += Math.Min(Rsize[i], Lsize[i]);
            }

            Console.WriteLine(rez.ToString());
        }

        //    private static void Main(string[] args)
        //    {
        //        int n = Int32.Parse(Console.ReadLine());

        //        List<Shoe> shoes = new List<Shoe>();

        //        int count = 0;

        //        for (int i = 0; i < n; i++)
        //        {
        //            Shoe shoe = new Shoe();

        //            string line = Console.ReadLine();

        //            string[] data = line.Split(' ');

        //            shoe.Size = Int32.Parse(data[0]);
        //            shoe.Leg = data[1];

        //            if (i > 0)
        //            {
        //                foreach (var item in shoes)
        //                {
        //                    if (shoe.Leg != item.Leg && shoe.Size == item.Size && !item.IsPaired && !shoe.IsPaired)
        //                    {
        //                        count++;
        //                        item.IsPaired = shoe.IsPaired = true;
        //                    }
        //                }
        //            }

        //            shoes.Add(shoe);
        //        }

        //        Console.WriteLine(count.ToString());

        //        Console.ReadLine();
        //    }
        //}

        //internal class Shoe
        //{
        //    public int Size { get; set; }
        //    public string Leg { get; set; }
        //    public bool IsPaired { get; set; } = false;
        //}
    }
}