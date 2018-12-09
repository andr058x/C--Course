using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eta;
            eta = new int[5];

            Console.WriteLine("Inserisci il 1 numero");
            eta[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il 2 numero");
            eta[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il 3 numero");
            eta[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il 4 numero");
            eta[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il 5 numero");
            eta[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(eta[0]);
            Console.WriteLine(eta[1]);
            Console.WriteLine(eta[2]);
            Console.WriteLine(eta[3]);
            Console.WriteLine(eta[4]);



            Console.WriteLine("Premi un tasto!");
            Console.ReadKey();
        }
    }
}
