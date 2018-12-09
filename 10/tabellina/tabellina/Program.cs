using System;

namespace tabellina
{
    class Program
    {
        static void Main(string[] args)
        {
            inizio:

            int b;  //inizializzo la base
            Console.WriteLine("Inserisci la base");  //scrivo la stringa inserisci la base
            b = Convert.ToInt32(Console.ReadLine()); // converto la base in un numero intero

            int i, n; // inizializzo due variabili
            for(i=1; i<=10; i++)  //ciclo for 
            {

                n = b * i; //moltiplico la base per i che si incrementa
                Console.WriteLine($"{b}x{i}={n}");  //stampo il risultato della tabellina

            }
            domandafinale: //per ricominciare se qualcuno inserisce qualconsa di diverso da si o no
            Console.WriteLine("Vuoi riconminciare da capo [SI o NO] ?"); // stampo una stringa per far scegliere l'utente
            String r = Console.ReadLine();  // l'utente può fare la sua scelta
            r = r.ToUpper(); // converto la stringa i caratteri maiusc

            if (r == "SI" || r == "NO") // Qui controlliamo che sia stato inserito UN INPUT VALIDO... controllo if else se r è uguale a si oppure a no
            {

                if (r == "SI") // se r è si torna all'inizio e richiede di nuovo la base
                {
                    goto inizio; 
                }
                Console.WriteLine("Premi per uscire dal programma"); // da l'opzione premi un tasto per uscire
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Devi inserire o SI o NO.. senza altri caratteri o spazi!"); // se r non è uguale a si va su al punto della domanda finale
                goto domandafinale;

            }
        }
    }
}
