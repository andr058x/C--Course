using System;

namespace funzioni02
{
    class Program
    {
        static void aspettauntasto()  //creaiamo una funzione che non restituisce un valore per scrivere a video premiun tasto e per non fare chiudere il programma
        {
            Console.WriteLine("Premi un tasto"); //scriviamo a video premi un tasto
            Console.ReadKey(); //evitiamo che il programma si chiuda

        }

        static void menu() // Creiamo una funzione che non restituisce nessun valore per visualizzare un menu
        {
            Console.WriteLine("1) Somma 2 numeri interi");  //Scriviamo a video che scegliendo 1 farai una somma
            Console.WriteLine("2) Sottrai 2 numeri interi"); //Scriviamo a video che scegliendo 1 farai una sottrazione
            Console.WriteLine("3) Moltiplica 2 numeri interi"); //Scriviamo a video che scegliendo 1 farai una moltiplicazione
            Console.WriteLine("4) Esci"); // Premendo 4 esci dal menu
        }

        static int somma(int n1, int n2) //Creiamo una funzione che restituisce un valore
        {
            return n1 + n2;  // Sommiamo due numeri
        }
        static int sottrazione(int n1, int n2) //Creiamo una funzione che restituisce un valore
        {

            return n1 - n2; // Sottrazione di due numeri
        }
        static int moltiplicazione(int n1, int n2) //Creiamo una funzione che restituisce un valore
        {

            return n1*n2; // Moltiplicazione di due numeri
        }   

        static void Main(string[] args)
        {
            inizio: // ci serve un punto per arrivare con goto
            menu(); // chiamiamo la funzione menu
            int scelta = Convert.ToInt32(Console.ReadLine()); //Convertiamo una stringa che è la scelta dell'utente per il menu in un numero intero 
            if (scelta == 1) // partiamo con un if con un confronto(è una operazione) tra la scelta ed il numero 1
            {
                Console.WriteLine("Inserisci il primo numero"); //stampiamo a video inserisci il primo numero
                int n1 = Convert.ToInt32(Console.ReadLine());  //l'utente inserisce il primo numero che viene convertito in un numero intero
                Console.WriteLine("Inserisci il secondo numero"); //stampiamo a video inserisci il secondo numero
                int n2 = Convert.ToInt32(Console.ReadLine()); //l'utente inserisce il primo numero che viene convertito in un numero intero
                int s = somma(n1, n2);  // chiamiamo la funzione somma
                Console.WriteLine($"La somma è {s}"); //stampiamo la stringa con dentro la variabile somma
                aspettauntasto();  // chiamiamo la funzione aspettauntasto
            }
            else if (scelta == 2)  //confronto tra la scelta dell'utente ed il numero 2
            {
                Console.WriteLine("Inserisci il primo numero");  //stampiamo a video inserisci il primo numero
                int n1 = Convert.ToInt32(Console.ReadLine());  //convertiamo la scelta dell'utente in un numero intero
                Console.WriteLine("Inserisci il secondo numero"); //stampiamo a video inserisci il secondo numero
                int n2 = Convert.ToInt32(Console.ReadLine()); //convertiamo la scelta dell'utente in un numero intero
                int s = sottrazione(n1, n2); //chiamiamo la funzione sottrazione
                Console.WriteLine($"La sottrazione è {s} ");  //scriviamo a video la stringa con la variabile s
                aspettauntasto(); // chiamiamo la funzione aspettauntasto

            }
            else if (scelta == 3) //confronto tra la scelta dell'utente ed il numero 3
            {
                Console.WriteLine("Inserisci il primo numero");  //stampiamo a video inserisci il primo numero
                int n1 = Convert.ToInt32(Console.ReadLine()); //convertiamo la scelta dell'utente in un numero intero
                Console.WriteLine("Inserisci il secondo numero"); //stampiamo a video inserisci il secondo numero
                int n2 = Convert.ToInt32(Console.ReadLine()); //convertiamo la scelta dell'utente in un numero intero
                int s = moltiplicazione(n1, n2); //chiamiamo la funzione moltiplicazione
                Console.WriteLine($"La moltiplicaizone è {s}");  //scriviamo a video la stringa con la variabile s
                aspettauntasto(); // chiamiamo la funzione aspettauntasto
            }
            else if (scelta == 4) //confronto tra la scelta dell'utente ed il numero 4
            {
                Console.WriteLine("Arrivederci");  //scriviamo a video la parola arrivederci
                goto fine;  //ci serve per saltare goto inizio
            }
            goto inizio;  //ci serve per tornare all'inizio
            fine: 
            aspettauntasto(); // chiamiamo la funzione aspettauntasto

        }
    }
}
    