using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Devo creare un programma dove inserisci dei nomi e poi possiamo cercare se è presente un nome
            // Per prima cosa creo un array
            string risposta_finale;
            // inizio:
            do
            {
                Console.WriteLine("Quante persone vuoi inserire?");
                int n = Convert.ToInt32(Console.ReadLine());


                string[] people; //creo l'array
           
                people = new string[n]; //instanzio l'array

                int i; //inizializzo la variabile i
                for (i = 0; i<=n-1; i++) // creo un ciclo for per fare inserire i 7 nomi

                {
                    Console.WriteLine($"Inserisci la {i + 1} persona"); //stampo a video la scritta inserisci la persona numero 1 e via via la numero 2 fino alla numero 7

                    /*
                     * string nome = Console.ReadLine();
                    people[i] = nome.ToUpper();
                    */
                    people[i] = Console.ReadLine().ToUpper(); //do la possibilità all'utente di inserire i nomi e li converto in maiuscolo

                }
                Console.WriteLine("Adesso repiloghiamo");  //stampo a video la scritta perchè successivamente andrò a stampare i nomi che ho ottenuto dall'utente
                for (i = 0; i<=n-1; i++)  //con questo ciclo for adnrò a stampare
                 {
                    Console.WriteLine($"La {i + 1} persona è {people[i]}"); //questo è il comando per stampare usando delle variabili dentro la stringa
                 }

                Console.WriteLine("Inserisci il nome da cercare");  //stampo a video la sritta per andare ad ottenere un  nome da cercare dall'utente
                string nome = Console.ReadLine().ToUpper();  //comando per fare inserire il nome da cercare dall'utente


                bool trovato = false;  //creo una variabile booleana
                i = 0; //inizializzo la i
                while (i <= n - 1 && trovato == false)  //creo un ciclo while
                {
                    if (people[i] == nome)  //un if e else dentro al ciclo while per controllare se nell'array c'e' il nome inserito dall'utente
                    {
                        trovato = true;  //se il nome viene trovato si ferma
                    }
                    else
                    {
                        i++;  //altrimenti continua a cercare
                    }
                }
                if (trovato == true)  //se il nome viene trovato andiamno a stampare il nome e la posizione con il successivo comando 
                {
                    Console.WriteLine($"Il nome c'e' ed è presente alla posizione {i}"); //con questo comando stampo a video il nome e la posizione
                }

                do {
                        Console.WriteLine("vuoi ripetere l'esecuzione del programma? [SI, NO]");
                        risposta_finale = Console.ReadLine().ToUpper();
                    } while (risposta_finale!= "SI" && risposta_finale!="NO");
                // Quando arriviamo qui, la risposta sarà O "SI" O "NO"

                /*
                 * if (risposta_finale == "SI")

                {
                    goto inizio;
                }
              */
            
                

            } while (risposta_finale=="SI");

            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
