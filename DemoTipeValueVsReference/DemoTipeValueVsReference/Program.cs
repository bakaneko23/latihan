using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTipeValueVsReference
{
    class Program
    {
        static void TesTipeDasar()
        {

            int bil1 = 12;
            int bil2 = bil1;

            Console.WriteLine("bil2 = " + bil2);
            bil2 = 23;

            Console.WriteLine("bil1 = " + bil1);
        }

    class Siswa
        {
        public string Nis { get; set; }
        public string Nama { get; set; }

        }


        static void TesTipeReference()
        {
            Siswa siswa1 = new Siswa();
            siswa1.Nis = "12345";
            siswa1.Nama = "Adi";

            Siswa siswa2 = siswa1;

            Console.WriteLine("Nama Siswa 1 = " + siswa1.Nama  );

            siswa2.Nama = "Rudi";
            Console.WriteLine("Nama Siswa 2 = " + siswa1.Nama );

        }


        static void Main(string[] args)
        {
            //TesTipeDasar();
            TesTipeReference();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
