using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrePost
{
    class Program
    {
        static void IncrementAndDecrement()
        {
            int x = 1;
            int y = x + x++;

            Console.WriteLine(string.Format("Hasilnya = {0}", y));
            Console.WriteLine(string.Format("Nilai x = {0}", x));
            Console.WriteLine(string.Format("Decrement = {0}", y--));

            x = 1;
            y = x + ++x;

            Console.WriteLine(string.Format("\nHasilnya = {0}", y));
            Console.WriteLine(string.Format("Nilai x = {0}", x));
            Console.WriteLine(string.Format("Decrement = {0}", --y));


        }
        static void Main(string[] args)
        {
            IncrementAndDecrement();
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
        }
    }
}
