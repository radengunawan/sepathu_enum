using System;
using System.Collections.Generic;
using System.Text;

namespace sepathu_enum
{
    class Lemari_Sepatu
    {
        private readonly List<Sepatu> daftar_sepatu = new List<Sepatu>();

        public void PrintSepatu()
        {
            if (daftar_sepatu.Count == 0)
            {
                Console.WriteLine("\n No shoe (empty)");
            }
            else
            {
                Console.WriteLine("\n We have some shoes inside:");
                int i = 1;
                foreach (Sepatu spt in daftar_sepatu)
                {
                    Console.WriteLine($"The-{i++}-th shoe : {spt.Gambaran}");
                }
            }
        } //END PrintSepatu


        public void AddShoe()
        {
            Console.WriteLine("\n Add a shoe");
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine($"Press {i} to add a {(Gaya)i}");

            }

            Console.Write("Enter a style: ");

            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.Write("What color: ");
                string color = Console.ReadLine();
                Sepatu ggg = new Sepatu( (Gaya) style,color);
                daftar_sepatu.Add(ggg);
            }

        } //END AddShoe


        public void PopShoe()
        {
            Console.Write("\n Which no. of shoe u wanna remove? ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int nomorUrut) &&
                                (nomorUrut >= 1) && (nomorUrut <= daftar_sepatu.Count))
            {
                Console.WriteLine($"\nDeleting {daftar_sepatu[nomorUrut - 1].Gambaran}");
                daftar_sepatu.RemoveAt(nomorUrut - 1);
            }

        }



    } //END class
} // END namespace
