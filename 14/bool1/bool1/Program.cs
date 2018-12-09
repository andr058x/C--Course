using System;

namespace bool1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci un numero"); //Stampiamo a video la stringa inserisci un numero
            int n= Convert.ToInt32(Console.ReadLine()); //Aspettiamo l'inserimento di una scelta che viene convertita ad un numero intero

            bool confronto; // Creiamo una variabile booleana, una che può contenere solo valori TRUE e FALSE
            confronto = (n > 10);  // Eseguiamo una operazione di confronto >= che ci darà TRUE o FALSE a seconda che n sia maggiore, uguale o minore di 10
            // A questo punto la variabile confronto contiene TRUE o FALSE
            if(confronto == true)  //if è un costrutto di C# che, se tra parentesi ha TRUE allora esegue quello che ha di seguito (magari tra parentesi graffe)
            {
                Console.WriteLine("Il tuo numero è maggiore di 10"); // Scrive semplicemente a video che il numero inserito è maggiore di 10
            }
            else // else è un costrutto che funziona se prima c'era un if e fa quello che segue se l'if conteneva un FALSE tra parentesi
            {
                Console.WriteLine("Il tuo numero è minore od uguale di 10"); // questo scrive semplicemente a video che il numero inserito è minore od uguale di 10
            }

            Console.WriteLine("Premi un tasto per terminare"); // solito messaggio a video che avverte l'utente che deve premere un tasto
            Console.ReadKey(); // resa in attesa di un tasto

        }
    }
}
