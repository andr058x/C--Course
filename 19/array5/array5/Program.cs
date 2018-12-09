using System;

namespace array5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //questa variabile servirà a contenere il numero di elementi dell'array
            Console.WriteLine("Quanti numeri vuoi inserire?"); //scrive a video di inserire il numero degli elementi dell'array
            n = Convert.ToInt32(Console.ReadLine()); //fa inserire il numero degli elementi e lo memorizza in n

            int[] numeri; //creiamo l'array
            numeri = new int[n]; // instanziamo l'array

            int i;  // dichiariamo la variabile i , che useremo come indice del ciclo for per l'array
            for (i=0;i<=n-1;i++) // il for fa andare la i da 0 ad n-1
            {
                Console.WriteLine($"inserisci il {i + 1} valore!"); // chiediamo l'inserimento all'utente di un numero
                numeri[i]= Convert.ToInt32(Console.ReadLine()); // ci facciamo inserire il numero nella i-ma celletta dell'array
            }
            // Adesso dobbiamo riepilogare la lista
            for (i=0; i<=n-1; i++) // // il for fa andare la i da 0 ad n-1 (così ci scorriamo tutto l'array)
            {
                Console.Write(numeri[i]); // Scriviamo il numero di posizione i
                Console.Write(" - "); // mettiamo un trattino
            }
            // Adesso dobbiamo permettere all'utente di cercare un numero nella lista inserita
            int x; // x servirà a far inserire il numero da cercare.
            Console.WriteLine("Inserisci il numero da cercare!"); // Scriviamo a video l'ordine all'utente di inserire il numero da cercare
            x = Convert.ToInt32(Console.ReadLine()); // facciamoci inserire dall'utente il numero e memorizziamolo in x
            // adesso x contiene il numero da cercare...
            // Ora il trucco sarà scorrere tutto l'array e contare quante volte ricorre x dentro l'array  numeri
            int c; //creiamo una variabile c, per contare. Partiremo mettendoci 0 e poi la aumenteremo di 1 (la incrementiamo) ogni volta che troviamo in numeri una celletta che contiene lo stesso numero di x
            c = 0; // mettiamo 0 dentro c
            for (i=0; i<=n-1; i++) // facciamo andare i da 0 a n-1
            {
                if (numeri[i]==x) // controlliamo per ogni valore di i, se numeri[i] è unguale ad x
                {
                    c++; // se lo è , incrementiamo di 1 c
                }
            }
            // Arrivatiu qui.. se non c'è nessun numero uguale ad x, in numeri, allora c sarà zero, sennò conterrà quante volte è presente
            if (c>0) // Se c è maggiore di zero, e quindi dentro numeri sono stati trovati un certo quantitativo di valori uguali ad x..
            {
                Console.WriteLine($"SI! Il numero {x} e' presente, ben {c} volte nell'array "); // Scriviamo che x c'era ed era presente c volte
            }
            else // altrimenti...
            {
                Console.WriteLine($"Il numero {x} non è presente"); // Scriviamo che x non era presente... 
            }
            
            Console.WriteLine("Premi u tasto per terminare"); // Chiediamo di premerte un tasto per terminare
            Console.ReadKey(); // Restiamo in attesa della pressione del tasto...,
        }
    }
}
