using System;

namespace switchvar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un nome");
            string A = Console.ReadLine();

            Console.WriteLine("Inserisci un altro nome");
            string B = Console.ReadLine();

            Console.WriteLine($"A contiene {A}");
            Console.WriteLine($"B contiene {B}");

            Console.WriteLine("Premi un tasto per INVERTIRLE");

            Console.ReadKey();
            Console.WriteLine("Invertiamole");

            string C;
            C = A;
            A = B;
            B = C;
            

            Console.WriteLine($"A contiene {A}");
            Console.WriteLine($"B contiene {B}");


            Console.WriteLine("Premi un tasto!");
            Console.ReadKey();
        }
    }
}
