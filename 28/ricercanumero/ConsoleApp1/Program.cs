using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] numeri;  //creo un array
             Console.WriteLine("Quanti numeri vuoi inserire?");  //chiedo all'utente quanti numeri vuole inserire
             int n = Convert.ToInt32(Console.ReadLine());  //Converto il numero che mi da in numero intero
             numeri = new int[n]; //instanzio l'array


             
             int i; //inizializzo la i per il ciclo for
             for (i = 0; i <= n-1; i++)  // creo un ciclo for per fare inserire i numeri all'utente
             {
                Console.WriteLine($"Inserisci il {i + 1} numero ");  //Scrivo a video di inserire i numeri dentro al ciclo
                numeri[i] = Convert.ToInt32(Console.ReadLine());  //converto i numeri da strighe a numeri interi
             }

            Console.WriteLine("Adesso facciamo un riepilogo");  //avviso l'utente che adesso andrò a stampare un riepilogo

            for( i=0; i<= n-1; i++)  //creo un ciclo for per stampare il riepilogo
            {

                Console.WriteLine($"Il {i + 1} numero e' {numeri[i]}"); //stampo dentor al ciclo for il riepilogo
            }


            Console.WriteLine("Quale numero vuoi cercare?");  //chiedo all'utente se vuole cercare un numero
            int num = Convert.ToInt32(Console.ReadLine());  //converto il numero in un numero intero

            /*
             * Adesso DOBBIAMO CERCARE num dentro l'array numeri.
             * Dobbiamo scorrere tutte le celle dell'array e verificare
             *  se ogni cella di numeri è o meno uguale a num
             *  se troviamo la cella uguale allora dobbiamo fermarci
             *  se non la troviamo, dobbiamo andare avanti nella ricerca fino alla fine.
             */
            bool trovato = false; // usiamo la variabile booleana trovato per memorizzare true o falso, a seconda che il numero num ci sia o meno 
            i = 0; // mettiamo in i il valore 0 e poi cerchiamo dentro l'array numeri usando come indice la variabile i, incrementandola man mano
            while (i<=n-1 && trovato==false) // il ciclo serve a cercare in questo caso. Dentro il ciclo controlleremo ogni singola cella di numeri se è uguale a num
            {
                if (numeri[i]==num) // se troviamo il numero....
                { // allora...
                    trovato = true; // mettiamo true dentro trovato. Questo fatto fermerà il ciclo perchè dentro trovato ci sarà true
                }
                else // se non lo abbiamo trovato..
                {
                    i++;
                }
            }
            if (trovato == true)  // creo un if per controllare se la variabile trovato è true
            {
                Console.WriteLine($"Il numero c'e' ed è si trova alla posizione numero {i}");  //se la variabile trovato è true stampa la posizione

            }


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();


        }

    }
}
