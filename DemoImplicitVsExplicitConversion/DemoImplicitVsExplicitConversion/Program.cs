using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoImplicitVsExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesImplicitConversion();
            TesExplicitConversion();

            Console.WriteLine("\nTekan apa aja buat keluar...");
            Console.ReadKey();
        }

        static void TesImplicitConversion()
        {
            int bil1 = 12;
            float bil2 = bil1; // implicit casting
            Console.WriteLine("Bilangan 2 = " + bil2);
        }

        static void TesExplicitConversion()
        {
            float bil2 = 12.5f;
            int bil1 = (int)bil2; // explicit casting
            Console.WriteLine("Bilangan 1 = " + bil1);
        }
    }
}
