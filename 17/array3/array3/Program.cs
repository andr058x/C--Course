using System;

namespace array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quante persone ci sono di cui memorizzare l'età?");//Scriviamo a video di dirci il numero di persone
            int n = Convert.ToInt32(Console.ReadLine());//creiamo la variabile n e dentro mettiamo il valore inserito dall'utente
            //adesso dobbiamo creare un array per contenere l'età delle persone... dovrò essere un array di n elementi
            int[] eta;// creiamo la variabile eta che è una array di interi
            eta = new int[n];// istanziamo gli n elementi
            int i;//dichiariamo la variabile i per il for
            for (i = 0; i < n; i++)//con il for facciamo andare i da zero a n-1
            {
                Console.WriteLine($"Inserisci il {i + 1} numero");// chiediamo all'utente di inserirci il numero di questa casella, ma siccome i parte da zero per maggiore comprensione dell'utente scriviamo i+1
                eta[i] = Convert.ToInt32(Console.ReadLine());//facciamo inserire la casella numero i
            }
            // stampiamo a video l'intera lista dei numeri che abbiamo inserito
            for (i = 0; i < n; i++)//riutilizziamo la varibile i per il for che andrà da zero fino a n-1
            {
                Console.WriteLine(eta[i]);//scriviamo a video di volta in volta l'elemento numero i dell'array età
            }

            Console.WriteLine("Premi un tasto!"); // chiediamo di premere un tasto
            Console.ReadKey();// attendiamo la pressione del tasto
        }
    }
}
