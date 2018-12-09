using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma risolve le equazioni di primo grado del tipo ax+b=0");  //Scriviamo a video cosa fa questo programma
            Console.WriteLine("Per favoe inserisci il valore del coefficiente a");  //Chiediamo all'utente di inserire il valore di a
            float a; //dichiariamo la varibile a
            a = Convert.ToSingle(Console.ReadLine()); // facciamoci inserire dall'utente, dall'esterno, il coefficiente e convertiamo la valore in un float in modo che possa andare nella variabile
            Console.WriteLine("Per favoe inserisci il valore del coefficiente b"); //Chiediamo all'utente di inserire il valore di a
            float b; //dichiariamo la varibile b
            b = Convert.ToSingle(Console.ReadLine()); / facciamoci inserire dall'utente, dall'esterno, il coefficiente e convertiamo la valore in un float in modo che possa andare nella variabile
            Console.WriteLine($"Quindi l'equazione di cui calcolare la x e' {a}x+{b}=0");  //scriviamoun messaggio a video
            float x; //dichiariamo la variabile x
            x = -b / a; // calcoliamo il risultato 
            Console.WriteLine($"Il valore della x e' {x}"); // stampiamo il risultato
            Console.WriteLine("Premi un tasto per terminare");  
            Console.ReadKey();
        }
    }
}
