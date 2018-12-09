using System;
/*
 *   Per fare l'ordinamento semplice, si scorrono tutte le cifre dalla prima alla PENULTIMA e si confrontano con quelle di destra.
 *   Se quella che che stiamo confrontando è maggiore di una di quelle alla sua destra, le scambiamo!
 * 
 * */
namespace ordinaarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] numeriA;          // numeriA è un array di interi   (in pratica questo comando crea un array senza nessuna casella)
            numeriA = new int[n];   // crea n caselle pronte all'uso per l'array numeriA  (questo comando crea n caselle associate all'array
            // Adesso l'array possiede n caselle ed è pronto ad essere usato!
            // Dobbiamo far inserire all'utente tutti i numeri da mettere in ciascuna casella dell'array numeriA
            int i;
            int j;

            for (i=0; i <= n - 1; i++)
            {
                Console.WriteLine($"Inserisci {i + 1} numeri");
                numeriA[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Stampo tutti i numeri a video");

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Il numero {i + 1} è il numero {numeriA[i]}");                
            }


            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();

            //ADESSO ORDINIAMO IN MODO CRESCENTE E STAMPIAMO  A VIDEO
            for (i=0;i<=n-2;i++) // ti scorri tutti i valori degli indici dell'array da 0 ad un indice prima n-1... cioè ti fermi una casella prima 
            {                
                for (j=i+1; j<=n-1; j++) // 
                {
                    if (numeriA[i]>numeriA[j])
                    {
                        int x;
                        x = numeriA[i];
                        numeriA[i] = numeriA[j];
                        numeriA[j] = x;
                    }
                }
            }
            Console.WriteLine("Adesso lo stampo ordinato in modo crecente");

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Il numero {i + 1} è il numero {numeriA[i]}");
            }

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();

            //ADESSO ORDINIAMO IN MODO DECRESCENTE E STAMPIAMO  A VIDEO
            for (i = 0; i <= n - 2; i++) // ti scorri tutti i valori degli indici dell'array da 0 ad un indice prima n-1... cioè ti fermi una casella prima 
            {
                int j;
                for (j = i + 1; j <= n - 1; j++) // 
                {
                    if (numeriA[i] < numeriA[j])
                    {
                        int x;
                        x = numeriA[i];
                        numeriA[i] = numeriA[j];
                        numeriA[j] = x;
                    }
                }
            }
            Console.WriteLine("Adesso lo stampo ordinato in modo de" +
                "crecente");

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Il numero {i + 1} è il numero {numeriA[i]}");
            }



            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
