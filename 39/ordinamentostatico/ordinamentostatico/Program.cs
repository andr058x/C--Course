using System;

namespace ordinamentostatico
{
    class Program
    {
        static int n;
        static string[] nomi;
        static void inserisci_dati()
        {

            int i;
            
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Inserisci {i + 1} nomi");
                nomi[i] = Console.ReadLine();
            }
        }

        static void stampa_a_video()
        {
           
            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Il nome {i + 1} è il nome {nomi[i]}");
            }
        }


        static void ordina()
        {

            
            int j;
            for (int i = 0; i <= n - 2; i++)
            {
                for (j = i + 1; j <= n - 1; j++)
                {

                    if (String.Compare(nomi[i], nomi[j]) > 0) // if (nomi[i] > nomi[j])
                    {
                        string s = nomi[i];
                        nomi[i] = nomi[j];
                        nomi[j] = s;

                    }

                }
            }
        }
        static void Main(string[] args)
        {
            /*
             *
             * 
             * 1)  chiedere all'utente QUANTI nomi si vuole inserire
             * 2)  creare un array per i nomi
             * 3)  istanziare il numero di celle per l'array equivalente al numero che ne vuole inserire l'utente
             * 4)  eseguire un ciclo per l'inserimento di tutti i nomi
             * 5)  riepilogare tutti i nomi
             * 6)  chiedere di premere un tasto per ordinare
             * 7)  lasciare che l'utente prema un tasto qualsiasi
             * 8)  ordinare l'arrat
             * 9)  visuaizzare l'arrat
             * 10) far premere un tasto per chiudere
             * */

            Console.WriteLine("Quanti nomi vuoi inserire?"); //Scrivo a video la domanda quanti nomi vuoi inserire            
            n = Convert.ToInt32(Console.ReadLine()); //faccio inserire all'utente il numero di nomi per poi convertirlo
              //dichiaro un array
            nomi = new string[n]; //istanzio l'array         
            inserisci_dati();  //chiamo la funzione che fa inserire all'utente i nomi 
            Console.WriteLine("Stampo tutti i nomi a video");  //stampo la scritta che avvisa che stamperò tutti i nomi inseriti dall'utente
            stampa_a_video();//chiamo la funzione per stampare i nomi a video
            Console.WriteLine("Premere un tasto per ordinare"); //stampo una scritta per avvisare l'utente che adesso i nomi verranno ordinati
            Console.ReadKey(); //ferma il programma per la lettura
            ordina(); // chiamo la funzione per ordinare i nomi
            stampa_a_video(); // richiamo la funzione per la seconda volta per poter stampare i nomi

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
