using System;

namespace prove_variabili_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prove variabili 2!");  //Stampo a video
            int x = 5;  //Creo una variabile e gli assegno un valore
            int y = 10;   //Creo una variabile e gli assegno un valore
            int somma = x + y;   //Somma tra due variabili
            Console.WriteLine(somma); //Stampo a video la variabile somma
            Console.ReadKey();
            x = 2;
            y = 4;
            Console.WriteLine("ora faremo un altro esempio");  //STampo a video una stringa
            Console.Write("x+y=");  //Stampo a video una stringa
            Console.WriteLine(x + y);  //Stampo a video una stringa
            Console.ReadKey();

        }
    }
}
