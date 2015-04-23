using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoModulus
{
    class Program
    {
        static void TesModulus()
        {
            int intDiv, intMod;
            double dblDiv, dblMod;

            intDiv = 10 / 3;
            intMod = 10 % 3;

            dblDiv = 10.0 / 3.0;
            dblMod = 10.0 % 3.0;

            Console.WriteLine("Hasil Div dan Mod dari 10 /3 = {0} {1}", intDiv, intMod);
            Console.WriteLine("Hasil div dan mod dari 10.0 /3.0 = {0} {1}", Math.Round(dblDiv, 2), dblMod);

        }
        static void Main(string[] args)
        {
            TesModulus();
            Console.WriteLine("\nPress Any Key... ");
            Console.ReadKey();
        }
    }
}
