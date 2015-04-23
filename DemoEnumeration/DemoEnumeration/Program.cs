using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnumeration
{

    class Program
    {
        static void Main(string[] args)
        {
            TesEnumeration();
            Console.WriteLine("\nTekan apa bae lah...");
            Console.ReadKey();
        }

        enum Warna
        {
            Merah, Putih, Biru
        }
        static void TesEnumeration()
        {
            Warna warna = Warna.Biru;

            switch (warna)
            {
                case Warna.Biru:
                    Console.WriteLine("Warna Biru");
                    break;
                case Warna.Merah:
                    Console.WriteLine("Warna Merah");
                    break;
                case Warna.Putih:
                    Console.WriteLine("Warna Putih");
                    break;

                default:
                    break;
            
            }
        }
    }  

}
