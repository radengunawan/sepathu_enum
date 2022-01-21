using System;

namespace sepathu_enum
{
    class Program
    {
        static Lemari_Sepatu lmrspt = new Lemari_Sepatu();

        static void Main(string[] args)
        {
            bool bener = true;
            while (bener)
            {
                lmrspt.PrintSepatu();

                Console.WriteLine("\nPress 'a' to add or 'r' to remove a shoe");

                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'a':

                    case 'A':
                        lmrspt.AddShoe();
                        break;
                    case 'r':
                    case 'R':
                        lmrspt.PopShoe();
                        break;
                    default:
                        return;
                }


            }
            
        }
    }
}
