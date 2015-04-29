using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSwitch
{
    class Program
    {
        static void LatihanSwitch()
        {
            Console.WriteLine("\nDemo Aplikasi Untuk Menentukan Suku Bunga");
            Console.WriteLine("\n==========================================");
            Console.WriteLine("\nMasukan Peringkat anda :");
            string Pilihan = Console.ReadLine().ToUpper();

            float bunga = 0.00f;

            switch(Pilihan)
            {
                case "A":
                case "B":
                    bunga = 0.11f;
                    break;
                case "C":
                    bunga = 0.15f;
                    break;
                case "D":
                    bunga = 0.17f;
                    break;
                case "E":
                    bunga = 0.19f;
                    break;
                default:
                    bunga = 0.21f;
                    break;
            }
            Console.WriteLine("\nBunga Anda : {0}%", bunga * 100);
        }
        static void Main(string[] args)
        {
            LatihanSwitch();
            Console.WriteLine("\nPress Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
