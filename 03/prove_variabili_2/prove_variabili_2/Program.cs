using System;

namespace prove_variabili_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prove variabili 2!");
            int x = 5;
            int y = 10;
            int somma = x + y;
            Console.WriteLine(somma);
            Console.ReadKey();
            x = 2;
            y = 4;
            Console.WriteLine("ora faremo un altro esempio");
            Console.Write("x+y=");
            Console.WriteLine(x + y);
            Console.ReadKey();

        }
    }
}
