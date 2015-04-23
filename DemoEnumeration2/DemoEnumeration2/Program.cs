using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnumeration2
{
    class Program
    {
        static void Main(string[] args)
        {
            TesEnumeration();

            Console.WriteLine("\nTekan apa aja untuk keluar...");
            Console.ReadKey();
        }

        enum Warna
        {
            Merah, Kuning, Hijau
        }
         static void TesEnumeration()
        {
            Warna warna = Warna.Hijau;
             switch (warna)
             {
                 case Warna.Merah:
                     Console.WriteLine("Warna Merah");
                     break;

                 case Warna.Kuning:
                     Console.WriteLine("Warna Kuning");
                     break;

                 case Warna.Hijau:
                     Console.WriteLine("Warna Hijau");
                     break;

                 default:
                     break;

             }
        }
    }
}
