using System;

namespace persone1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] persone;
            persone = new string[10];
           
            for(int i=0; i<=9; i++)
            {
                Console.WriteLine($"Inserisci la {i+1} persona");
                persone[i] = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Adesso riepiloghiamo");
            for (int i=0; i<=9;i++)
            {
                Console.WriteLine($" La {i + 1} persona e' {persone[i]}");
            }

            Console.WriteLine("inserisci il nome da cercare");
            string nome = Console.ReadLine().ToUpper();
            /*
             Adesso dobbiamo capire se dentro l'array persone c'è o no, il nome da cercare.
             Il Nome è dentro la variabile nome
             Quindi dobbiamo scorrerci TUTTO l'array persone e se troviamo che c'è una corrisponenza con il contenuto della variabile nome, 
             allora, dobbiamo segnarci che il nome c'è!
             
             */
            bool trovato = false; // usiamo la variabile booleana trovato per annotare SE il nome c'è o no. Presumiamo che non ci sia, dato che non abbiamo ancora scorso la lista e quindi mettiamo a FALSE il valore di trovato
            for (int i=0; i<=9; i++) // usiamo la variabile i per farla andare da 0 a 9, ovvero i assumerà, uno per uno, tutti i valori degli indici dell'array persone.
            {
                // qui i avrà un valore da 0 a 9, prima 0, poi 1, poi 2.... fin o a 9
                if (persone[i]==nome) // ogni volta sarà eseguito un confronto.. se persone[i] equivale al contenuto della variabile nome, che è la parola da cercare, allora.. 
                {
                    trovato = true; // ... in tal caso, porrei la variabile trovato a TRUE
                }
                // che abbia trovato o meno la corrispondenza il ciclo for continuerà fino a 9
            }
            // arrivati qui, i avrà scorso tutti i valori da 0 a 9 e se per caso in uno di questi si è trovato che persone[i] equivaleva alla parola dentro la variabile nome, la variabile trovato avra' assunto il valore TRUE
            /* Se trovato è ancora false, vuol dire che non c'è nesusn nome che corrisponde..
            /  altrimenti sarà rimasta pari a FALSE.
            Quindi ci troviamo nella condizione per cui se la variabile trovato contiene TRUE, vuol dire che la ricerca ha trovato il nome, altrimenti non lo ha trovato.
            Durante la ricerca, se anche ha trovato il contenuto di nome dentro l'array, ed ha posto trovato=TRUE, ha comunque poi proseguito fino alla fine, verificando anche le altre caselle. La cosa non cambia nulla, perchè
            una volta posto a TRUE il programma non torna a FALSE, per come lo abbiamo scritto.
            */
            // Ci bastertà controllare che trovato sia true
            if (trovato == true) // se trovato è true
            {
                Console.WriteLine("Il nome è presente nella lista"); // scriviamo a video che il nome è presente
            }
            else // altrimenti...
            {
                Console.WriteLine("Il nome non è presente nella lista"); // scriviamo a video che il nome non è presente
            }

            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
