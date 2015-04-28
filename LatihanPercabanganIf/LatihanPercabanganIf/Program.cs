using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPercabanganIf
{
    class Program
    {
        static void TestIf()
        {
            Console.WriteLine("Demo Aplikasi Untuk Menentukan Suku Bunga");
            Console.WriteLine("\n=========================================");
            Console.Write("\nMasukanPeringkat Anda :");
            string Peringkat = Console.ReadLine().ToUpper();

            float Bunga = 0.00F;
            
            if (Peringkat == "A" || Peringkat == "B")
                Bunga = 0.11f;
            else if (Peringkat == "C")
                Bunga = 0.15f;
            else if (Peringkat == "D")
                Bunga = 0.17f;
            else if (Peringkat == "E")
                Bunga = 0.19f;
            else
                Bunga = 0.21f;

            Console.WriteLine("\nBunga Anda : {0} %", Bunga * 100);
        }
        static void Main(string[] args)
        {
            TestIf();
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
            
        }
    }
}
