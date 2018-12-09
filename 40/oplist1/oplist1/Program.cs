using System;

namespace oplist1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Scrivere programma che:
             * 1) presenti un menù con le seguenti opzioni:
             *  A) INSERISCI NUMERI
             *  B) Somma numeri inseriti
             *  C) Fa la media dei numeri inseriti
             *  D) Moltiplica i numeri inseriti tra loro
             *  E) Esci
             *  Se una persona scrive A, gli verrà chiesto quanti numeri vuole inserire, si instanzierà l'array dei numeri a quella quantità di numeri
             *  Se una persona sceglia B o C o D, si farà l'operazione richiesta, a meno che l'array non sia vuoto, nel qual caso si risponderà che non si può fare senza numeri
             *  Fare questo programma PRIMA senza le funzioni e poi con le funzioni!
             * */
            int[] numeri = new int[0]; // Dichiaro QUI l'array che conterrà i numeri, perchè da qui ha la MASSIMA VISIBILITA' (scope) e tutti i blocchi di codice sottostanti lo "vedranno" e lo potranno usare
            string scelta;
            do
            {
                Console.WriteLine("Scegli una opzione");
                Console.WriteLine("A) inserisci numeri");
                Console.WriteLine("B) Somma i numeri inseriti");
                Console.WriteLine("C) Fai la media dei numeri inseriti");
                Console.WriteLine("D) Moltiplica i nmeri inseriti tra loro");
                Console.WriteLine("E) Esci");
                scelta = Console.ReadLine().ToUpper();

                if (scelta=="A") // Se la scelta è "A", possiamo chiedere quanti numeri inserire ed aggiungere le celle necessarie all'array, poi farci inserire i numeri... l'array sarà poi visibile anche da altri blocchi
                {
                    Console.WriteLine("Quanti numeri vuoi inseire?"); //Scritta a video quanti numeri vuoi inserire?
                    int n = Convert.ToInt32(Console.ReadLine()); // L'utente ci inserisc quanti numeri vuole inserire
                    numeri = new int[n];  // istanziamo l'array con il numero di caselle inserite dall'utente
                    int i;  //creiamo la variabile i
                    for(i=0;i<=n-1;i++) //avviamo un ciclo for per stampare
                    {
                        Console.WriteLine($"Inserisci il {i+1} numero");  //stampiamo a video
                        numeri[i] = Convert.ToInt32(Console.ReadLine()); //Fa inserire i numeri all'utente e li converte in numeri interi
                    }
                
                }// da questo momento l'array numeri è cambiato e tutti i blocchi sottostanti lo possono utilizare, vedendo cosa c'è dentro..
                // adesso vediamo cosa avviene se scegliamo altre opzioni
                else if (scelta=="B") // Se la scelta è "B" dobbiamo sommare i numeri presenti nell'array numeri
                {
                    /* Per sommare i numeri di un array, si scorre l'array sommando man mano dentro una variabile che parte da zero, tutti i numeri*/
                    // Da qui noi non sappiamo QUANTI numeri ci sono dentro l'array perchè la variabile n usata nel blocco "A" era una variabile locale e non visibile qui.. qui non esiste! 
                    // Quindi dobbiamo recuperare la lunghezza dell'array da scorrere. Possiamo creare nuovamente una variabile n e usarla per metterci dentro la lunghezza dell'array
                    int n = numeri.Length; // Recuperiamo tramite questa funzione la lunghezza dell'array e la mettiamo dentro la variabile n
                    int s = 0; // mettiamo 0 dentro la variabile che conterrà la somma...
                    for (int i=0;i<=n-1; i++) // Adesso scorriamoci tutto l'array, in modo che man mano andiamo ad aggiungere i numeri dentro s
                    {
                        s = s + numeri[i]; // in s, mettiamo i numeri che man mano troviamo, aggiungendoli a quello che c'è già dentro s
                    }
                    // Quando saremo usciti dal ciclo for, qui, avremo dentro s la somma di tutti i numeri
                    Console.WriteLine($"La somma e': {s}");// scriviamo a video la somma ottenuta

                }
                else if (scelta == "C") // Nel caso in cui sia stato scelto "C" (dobbiamo fare la media)
                {
                    /*
                     La media si fa sommando tutti i numeri e dividendo per la quantità di celle (se abbiamo: 4, 3, 5, 12... si sommano e si ha 24, e poi si divide x il numero di elementi ( x 4)... e si ottiene 6 (la media è 6)
                     */
                     /*
                      * Ancora una volta dobbiamo scorrere tutto l'array numeri, ma nuovamente non abbiamo la lunghezza  (il numero di elementi)
                      * Così la recuperiamo e la mettiamo in  una variabile...
                      * */
                    int n = numeri.Length;
                    int i; /* i ci servirà nel for... possiamo dichiararla anche direttamente nel for (come abbiamo fatto prima   for (int i=0;i<=n-1; i++) ... 
                             ma stavolta (tanto è uguale) la dichiariamo qui */
                    int s = 0; // s la mettiamo a 0
                    for (i = 0; i <= n - 1; i++) // ora ci scorriamo tutto numeri per aggiungere man mano i numeri ad s
                    {
                        s = s + numeri[i];
                    }
                    // arrivati qui s contiene la somma di tutti i numeri. Per fare la media dobbiamo solo dividerla con il numero di elementi, che è contenuto in n
                    // la media può anche avere dei numeri con la virgola, quindi meglio creare una variabile "media" di tipo double
                    double media = s / n; // creaimo la variabile media e mettiamoci dentro la MEDIA appunto, ovvero la divisione tra somma e numero di elementi
                    // a questo punto, dentro la variabile media c'è la media... 
                    Console.WriteLine($"La media e': {media}"); // scriviamo la media a video
                }
                else if (scelta == "D") // nel caso della scelta "D"  
                {
                    int n = numeri.Length;     //recupero la lunghezza dell'array               
                    int m = 1;  //dichiaro una variabile a 1
                    for(int i = 0; i<=n -1; i++) //ciclo for per moltiplicare 
                    {
                        m = m * numeri[i]; //qui moltiplichiamo m per i numeri di i
                    }
                    Console.WriteLine($"La moltiplicazione è : {m}"); //scriviamo a video il risultato
                }

            } while (scelta != "E");


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
