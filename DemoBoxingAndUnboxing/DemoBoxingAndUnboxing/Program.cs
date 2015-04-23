using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoBoxingAndUnboxing
{
    class Program
    {
       
        static void TesBoxingAndUnboxing()
        {
            ArrayList arrBilangan = new ArrayList();
            //proses boxing
            arrBilangan.Add(12);
            arrBilangan.Add(32);
            arrBilangan.Add(24);

            for(int i =0; i < arrBilangan.Count; i++)
            {
                // proses unboxing
                int bil = (int)arrBilangan[i];

                Console.WriteLine(bil.ToString());
            }
        }

        static void TesStronglyTypedCollection()
        {
            List<int> listBilangan = new List<int>();

            listBilangan.Add(12);
            listBilangan.Add(32);
            listBilangan.Add(24);

            for (int i = 0; i < listBilangan.Count; i++)
            {
                int bil = listBilangan[i];
                Console.WriteLine(bil.ToString());
            }

        }

        static void Main(string[] args)
        {
            TesBoxingAndUnboxing();
            //TesStronglyTypedCollection();
            Console.WriteLine("\nPress Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
