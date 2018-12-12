using System;

namespace cicli02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=0; i<=10; i++)  //Il ciclo for per stampare i numeri da 1(perchè partiamo da 1 ma solitamente partiamo da zero) a 10
            {
                Console.Write("i=");  //Questa è una stringa senza andare a capo
                Console.WriteLine(i); //Se qui mettessimo +1 potremmo partire da 1
            }
            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey();
        }
    }
}
