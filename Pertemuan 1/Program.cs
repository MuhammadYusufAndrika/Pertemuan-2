using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "kalkuolator";

            int a = 10;
            int b = 5;

            Console.WriteLine("Hasil pengurangan {0} + {1} = 2", a, b, penambahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = 2", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pemabagian {0} * {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\n tekan sembarang untuk key");
            Console.ReadKey();
        }

 
        static int penambahan(int a, int b)
        {return a + b;}

        static int pengurangan(int a, int b)
        { return a - b; }

        static int perkalian(int a, int b)
        {return a * b;}

        static int pembagian(int a, int b)
        {return a / b;}
    }
}



