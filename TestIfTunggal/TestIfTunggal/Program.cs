using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIfTunggal
{
    class Program
    {

        static void TestIfTunggal()
        {
            Console.Write("Nilai Anda :");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 60)
                Console.WriteLine("Anda Lulus\n");
        }

        static void TestIfElse()
        {
            Console.Write("Nilai Anda : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var keterangan = string.Empty;

            if (nilai >= 60)
                keterangan = "Anda Lulus";
            else
                keterangan = "Anda Tidak Lulus";

            Console.WriteLine(keterangan + "\n");
        }

        static void TestIfDenganTernary()
        {
            Console.Write("Nilai Anda : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var keterangan = nilai >= 60 ? "Anda Lulus" : "Anda Tidak Lulus";

            Console.WriteLine(keterangan + "\n");
        }

        static void TestIfMajemuk()
        {
            Console.Write("Masukan Nilai Angka : ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            var nilaiHuruf = string.Empty;

            if (nilai >= 80 && nilai <= 100)
                nilaiHuruf = "A";
            else if (nilai >= 100)
                nilaiHuruf = "Salah";
            else if (nilai >= 70)
                nilaiHuruf = "B";
            else if (nilai >= 60)
                nilaiHuruf = "C";
            else if (nilai >= 45)
                nilaiHuruf = "D";
            else
                nilaiHuruf = "E";

            Console.WriteLine("Nilai Huruf : {0}\n", nilaiHuruf);
        }

        static void TestIfMajemuk2()
        {
            Console.WriteLine("Pilih Bahasa Pemrograman");
            Console.WriteLine("=========================");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. VB.Net");
            Console.WriteLine("3. PHP");

            Console.WriteLine("\nMasukan Pilihan Anda");

            int pilihan = Convert.ToInt32(Console.ReadLine());

            var keterangan = string.Empty;

            if (pilihan == 1)
                keterangan = "C#";
            else if (pilihan == 2)
                keterangan = "VB.NET";
            else if (pilihan == 3)
                keterangan = "PHP";
            else 
                keterangan = "Pilihan yg salah";

            Console.WriteLine("Anda Memilih : {0}\n", keterangan);
        }
        static void Main(string[] args)
        {
            //TestIfTunggal();
            //TestIfElse();
            //TestIfDenganTernary();
            TestIfMajemuk();
            //TestIfMajemuk2();
            Console.WriteLine("\nTekan apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
