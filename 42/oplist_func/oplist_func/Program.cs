using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oplist_func
{
    class Program
    {
        static int[] numeri = new int[0]; // Dichiaro QUI l'array che conterrà i numeri, perchè da qui ha la MASSIMA VISIBILITA' (scope) e tutti i blocchi di codice sottostanti lo "vedranno" e lo potranno usare
        static void stampa_menu()
        {
            Console.WriteLine("Scegli una opzione");
            Console.WriteLine("A) inserisci numeri");
            Console.WriteLine("B) Somma i numeri inseriti");
            Console.WriteLine("C) Fai la media dei numeri inseriti");
            Console.WriteLine("D) Moltiplica i nmeri inseriti tra loro");
            Console.WriteLine("E) Stampa l'array");
            Console.WriteLine("F) Esci");
        }


        static void fai_inserire_array()
        {
            Console.WriteLine("Quanti numeri vuoi inseire?"); //Scritta a video quanti numeri vuoi inserire?
            int n = Convert.ToInt32(Console.ReadLine()); // L'utente ci inserisc quanti numeri vuole inserire
            numeri = new int[n];  // istanziamo l'array con il numero di caselle inserite dall'utente
            int i;  //creiamo la variabile i
            for (i = 0; i <= n - 1; i++) //avviamo un ciclo for per stampare
            {
                Console.WriteLine($"Inserisci il {i + 1} numero");  //stampiamo a video
                numeri[i] = Convert.ToInt32(Console.ReadLine()); //Fa inserire i numeri all'utente e li converte in numeri interi
            }
        }

        
        static void visualizza_array()
        {
            Console.WriteLine("Adesso l'array verrà stampato");
            Console.WriteLine("--------------------------------------------------------------");
            int n = numeri.Length;
            int i;
            Console.WriteLine("I numeri dell'array sono:");
            for (i=0; i<=n-1;i++)
            {
                Console.Write(numeri[i]);
                if (i<n-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("--------------------------------------------------------------");

        }


        static int somma()
        {
            /* Per sommare i numeri di un array, si scorre l'array sommando man mano dentro una variabile che parte da zero, tutti i numeri*/
            // Da qui noi non sappiamo QUANTI numeri ci sono dentro l'array perchè la variabile n usata nel blocco "A" era una variabile locale e non visibile qui.. qui non esiste! 
            // Quindi dobbiamo recuperare la lunghezza dell'array da scorrere. Possiamo creare nuovamente una variabile n e usarla per metterci dentro la lunghezza dell'array
            int n = numeri.Length; // Recuperiamo tramite questa funzione la lunghezza dell'array e la mettiamo dentro la variabile n
            int s = 0; // mettiamo 0 dentro la variabile che conterrà la somma...
            for (int i = 0; i <= n - 1; i++) // Adesso scorriamoci tutto l'array, in modo che man mano andiamo ad aggiungere i numeri dentro s
            {
                s = s + numeri[i]; // in s, mettiamo i numeri che man mano troviamo, aggiungendoli a quello che c'è già dentro s
            }
            // Quando saremo usciti dal ciclo for, qui, avremo dentro s la somma di tutti i numeri
            return s;
        }

        static double media()
        {
            int n = numeri.Length; 
            var s = somma();
            double m = s / n; // creaimo la variabile media e mettiamoci dentro la MEDIA appunto, ovvero la divisione tra somma e numero di elementi
            return m;
                           
        }

        static int moltiplicazione()
        {
            int n = numeri.Length;     //recupero la lunghezza dell'array               
            int m = 1;  //dichiaro una variabile a 1
            for (int i = 0; i <= n - 1; i++) //ciclo for per moltiplicare 
            {
                m = m * numeri[i]; //qui moltiplichiamo m per i numeri di i
            }
            return m;
        }
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
            
            string scelta;
            do
            {
                stampa_menu();
                scelta = Console.ReadLine().ToUpper();

                if (scelta == "A") // Se la scelta è "A", possiamo chiedere quanti numeri inserire ed aggiungere le celle necessarie all'array, poi farci inserire i numeri... l'array sarà poi visibile anche da altri blocchi
                {
                    fai_inserire_array();
                }
                else if (scelta == "B") // Se la scelta è "B" dobbiamo sommare i numeri presenti nell'array numeri
                {
                    int s = somma();
                    Console.WriteLine($"La somma e': {s}");// scriviamo a video la somma ottenuta

                }
                else if (scelta == "C") // Nel caso in cui sia stato scelto "C" (dobbiamo fare la media)
                {
                    double m = media();
                    Console.WriteLine($"La media e': {m}"); // scriviamo la media a video
                }
                else if (scelta == "D") // nel caso della scelta "D"  
                {
                    
                    int m = moltiplicazione();
                    Console.WriteLine($"La moltiplicazione è : {m}"); //scriviamo a video il risultato
                }
                else if(scelta == "E")
                {

                    visualizza_array();                   
                }

            } while (scelta != "F");


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
