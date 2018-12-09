using System;

namespace tabellina4
{
    class Program
    {
        static void Main(string[] args)
        {
            inizio: //è una bandierina per ripartire dopo il goto

            int b; //inizializzo la base
            Console.WriteLine("Inserisci la base"); //inserisco la base
            b = Convert.ToInt32( Console.ReadLine() );  //converto la stringa in un numero intero
        
            int i, n; //inizializzo due variabili 
            for(i=1; i<=10; i++) // ciclo for per la tabellina 
            {

                n = b * i; // n è uguale alla base per l'incrementazione di i
                Console.WriteLine($"{b}x{i}={n}"); // vado a stampare la base x i ed il totale

            }
            
            Console.WriteLine("Vuoi ricominciare? 1=SI  o 2=NO"); // scrivo di scegliere tra due opzioni
            int r = Convert.ToInt32(Console.ReadLine()); // ricevo l'opzione desiderata e la converto
            if (r==1) // controolo if se r è uguale a 1
            {
                goto inizio; //riparte dall'inizio se l'utente preme 1 altrimenti stampa la prossima istruzione che è premi un tasto per terminare
            }
            
            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey();
           
        }
    }
}
