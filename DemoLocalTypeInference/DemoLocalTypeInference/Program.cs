using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLocalTypeInference
{
    class Program
    {

        static void TesLocalTypeIference()
        {
            int bil1 = 10;
            var bil2 = 100;

            bool isCek1 = true;
            var isCek2 = false;

            string nama1 = "Rudi";
            string nama2 = "Andi";

            Console.WriteLine(bil1.GetType() + ", " + bil2.GetType());
            Console.WriteLine(isCek1.GetType() + ", " + isCek2.GetType());
            Console.WriteLine(nama1.GetType() + ", " + nama2.GetType());

        }


        static void Main(string[] args)
        {

            TesLocalTypeIference();

            Console.WriteLine("\nTekan apa aja untuk keluar");
            Console.ReadKey();
        }
    }
}
