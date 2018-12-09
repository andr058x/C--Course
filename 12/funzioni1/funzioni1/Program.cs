using System;

namespace funzioni1
{

    class Program
    {
        static void saluta() // Scive ciao ciao
        {
            Console.WriteLine("Ciao Ciao"); // serve a scrivere a video
        }

        static void aspettatasto() //questa funzione creata da noi serve a stampare a video "premi un tasto per continuare" e a fermare il programma altrimenti si chiuderebbe
        {
            Console.WriteLine("Premi un tasto per continuare"); //stampa a video Premi un tasto per continuare
            Console.ReadKey(); // blocca il programma altrimenti si chiuderebbe
        }

        static int somma(int p, int s)  //questa è una funzione creata da noi per fare la somma
        {
            return (p + s);  //somma primo numero e secondo numero e restituisce i risultato
        }

        static int readint()  //questa funzione è creata da noi per farsi inserire un numero dall'utente
        {
            return Convert.ToInt32(Console.ReadLine());  //si fa inseriree una stringa dall'utente e la converte in un numero e lo restituiosce
        }
        static void Main(string[] args)  // funzione principale del programma  quello che viene visto dal programma
        {
            saluta();  // chiama la funzione saluta
            Console.WriteLine("inserisci il primo numero");  //stampa inserisci il primo numero
            int primoNumero = readint();  //chiama la funzione per farsi inserire un numero dall'utente
            Console.WriteLine("inserisci il secondo numero");  //stampa inserisci il secondo numero
            int secondoNumero = readint();  // chiama la funzione per farsi inserire un numero dall'utente

            int s = somma(primoNumero, secondoNumero); //chiama la funzione somma
            Console.WriteLine($"La somma e' {s}"); // Stampa una stringa con delle variabili nel mezzo
            aspettatasto(); //chiama la funzione aspettatasto
        }
    }
}
