using System;

namespace Scambiointeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci un altro numero");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La variabile A contiene {A}");
            Console.WriteLine($"La variabile B contiene {B}");

            Console.WriteLine("Premi INVIO per invertirle");

            Console.ReadKey();

            int C;
            C = A;
            A = B;
            B = C;

            Console.WriteLine($"La variabile A contiene {A}");
            Console.WriteLine($"La variabile B contiene {B}");

            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
