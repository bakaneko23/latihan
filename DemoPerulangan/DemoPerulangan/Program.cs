using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPerulangan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestWhile();
            //TesDoWhile();
            //TesFor();
            //TesForEach();
            TesFor2();
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
        }

        static void TestWhile()
        {
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }     
        }
        static void TesDoWhile()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
        static void TesFor()
        {
            for (int i = 1; i<+ 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        static void TesFor2()
        {
            string[] arrNama = { "erick", "joni", "budi", "dony" };
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }
        }
        static void TesForEach()
        {
            string[] arrNama = { "erick", "joni", "budi", "dony" };
            foreach (string nama in arrNama )
            {
                Console.WriteLine(nama);
            }
        }
    }
}
