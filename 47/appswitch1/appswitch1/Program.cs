using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appswitch1
{
    class Program
    {
        static cliente[] array_di_clienti;
        public struct cliente //Creaiamo uno struct nominato cliente
        {
            public string nome;  //creiamo delle public strings per creare i dati del cliente nome, cognome, età...
            public string cognome;
            public int eta;
        }

        static void inserisci_clienti()
        {
            Console.WriteLine("Inserisci il numero di clienti");
            int n = Convert.ToInt32(Console.ReadLine());
            array_di_clienti = new cliente[n];  //istanziamo l'array usando anche il nome della struct
            int i; //creiamo la variabile i 74
            for (i = 0; i <= n - 1; i++) //creiamo un ciclo for inserire i dati dei clienti
            {
                Console.WriteLine($"inseriamo i dati del {i + 1} cliente"); //scritta a video
                Console.WriteLine("Insersci il nome");  //scritta a video
                array_di_clienti[i].nome = Console.ReadLine().ToUpper();  //facciamo inserire all'utente il nome del cliente
                Console.WriteLine("Insersci il cognome");
                array_di_clienti[i].cognome = Console.ReadLine().ToUpper();  //facciamo inserire all'utente il cognome del cliente
                Console.WriteLine("Insersci l'eta'");
                array_di_clienti[i].eta = Convert.ToInt32(Console.ReadLine().ToUpper());  //facciamo inserire all'utente l'età del cliente
            }
        }

        static void aggiungi_un_cliente()
        {
            int n = array_di_clienti.Length;
            //array_di_clienti = new cliente[n + 1];
            cliente[] A = new cliente[n];
            int i;
            for (i = 0; i <= n - 1; i++)
            {
                A[i].nome = array_di_clienti[i].nome;
                A[i].cognome = array_di_clienti[i].cognome;
                A[i].eta = array_di_clienti[i].eta;
            }
            array_di_clienti = new cliente[n + 1];
            for (i = 0; i <= n - 1; i++)
            {
                array_di_clienti[i].nome = A[i].nome;
                array_di_clienti[i].cognome = A[i].cognome;
                array_di_clienti[i].eta = A[i].eta;
            }
            Console.WriteLine("Insersci il nome");  //scritta a video
            array_di_clienti[n].nome = Console.ReadLine().ToUpper();  //facciamo inserire all'utente il nome del cliente
            Console.WriteLine("Insersci il cognome");
            array_di_clienti[n].cognome = Console.ReadLine().ToUpper();  //facciamo inserire all'utente il cognome del cliente
            Console.WriteLine("Insersci l'eta'");
            array_di_clienti[n].eta = Convert.ToInt32(Console.ReadLine().ToUpper());  //facciamo inserire all'utente l'età del cliente

        }

        static void visualizza_sul_video_i_clienti()
        {
            int i;
            int n = array_di_clienti.Length;
            Console.WriteLine("Adesso visualizziamo l'intera lista di clienti"); //stampiamo una scritta a video 
            for (i = 0; i <= n - 1; i++)   //creiamo un ciclo for per stampare i dati dei clienti
            {
                Console.WriteLine($"{i + 1}-mo cliente");
                Console.WriteLine($"NOME: {array_di_clienti[i].nome}");
                Console.WriteLine($"COGNOME: {array_di_clienti[i].cognome}");
                Console.WriteLine($"ETA': {array_di_clienti[i].eta}");
            }
        }

        static void visualizza_clienti_con_nome(string nome)
        {
            /* BISOGNA VISUALIZARE SOLO i clienti con il campo nome = alla variabile nome, qui passata come argomento tra parentesi */
            /* quindi: bisogna scorrere tutto l'array, e per ogni elemento confrontare il campo nome con la variabile nome.
             * Se è uguale visualizzare i dati di nome, cognome ed eta di quella cella
             */
            int n = array_di_clienti.Length;
            int i;
            for (i = 0; i <= n - 1; i++)
            {
                if (array_di_clienti[i].nome == nome)
                {
                    Console.WriteLine($"NOME: {array_di_clienti[i].nome}");
                    Console.WriteLine($"COGNOME: {array_di_clienti[i].cognome}");
                    Console.WriteLine($"ETA': {array_di_clienti[i].eta}");
                }
            }
        }

        static void visualizza_clienti_con_cognome(string cognome)
        {
            /* BISOGNA VISUALIZARE SOLO i clienti con il campo nome = alla variabile nome, qui passata come argomento tra parentesi */
            /* quindi: bisogna scorrere tutto l'array, e per ogni elemento confrontare il campo nome con la variabile nome.
             * Se è uguale visualizzare i dati di nome, cognome ed eta di quella cella
             */
            int n = array_di_clienti.Length;
            int i;
            for (i = 0; i <= n - 1; i++)
            {
                if (array_di_clienti[i].cognome == cognome)
                {
                    Console.WriteLine($"NOME: {array_di_clienti[i].nome}");
                    Console.WriteLine($"COGNOME: {array_di_clienti[i].cognome}");
                    Console.WriteLine($"ETA': {array_di_clienti[i].eta}");
                }
            }
        }

        static void visualizza_clienti_con_eta(int eta)
        {
            /* BISOGNA VISUALIZARE SOLO i clienti con il campo nome = alla variabile nome, qui passata come argomento tra parentesi */
            /* quindi: bisogna scorrere tutto l'array, e per ogni elemento confrontare il campo nome con la variabile nome.
             * Se è uguale visualizzare i dati di nome, cognome ed eta di quella cella
             */
            int n = array_di_clienti.Length;
            int i;
            for (i = 0; i <= n - 1; i++)
            {
                if (array_di_clienti[i].eta == eta)
                {
                    Console.WriteLine($"NOME: {array_di_clienti[i].nome}");
                    Console.WriteLine($"COGNOME: {array_di_clienti[i].cognome}");
                    Console.WriteLine($"ETA': {array_di_clienti[i].eta}");
                }
            }
        }


        static void cancella_cliente_in_posizione(int p)
        {
            int n = array_di_clienti.Length;
            if (p < n)
            {
                cliente[] A = new cliente[n - 1];
                int j = 0;
                for (int i = 0; i <= n-1; i++)
                {
                    if (i != p)
                    {
                        A[j].nome = array_di_clienti[i].nome;
                        A[j].cognome = array_di_clienti[i].cognome;
                        A[j].eta = array_di_clienti[i].eta;
                        j++;
                    }
                }
                n--;
                array_di_clienti = new cliente[n];
                for (int i = 0; i <= n - 1; i++)
                {
                    array_di_clienti[i].nome = A[i].nome;
                    array_di_clienti[i].cognome = A[i].cognome;
                    array_di_clienti[i].eta = A[i].eta;
                }
            }
        }

        static void Main(string[] args)
        {

            string scelta;
            do
            {
                Console.WriteLine("A) INSERISCI LISTA CLIENTI");
                Console.WriteLine("B) AGGIUNGI UN SOLO CLIENTE");
                Console.WriteLine("C) VISUALIZZA CLIENTI");
                Console.WriteLine("D) VISUALIZZA SOLO CLIENTI CON NOME");
                Console.WriteLine("E) VISUALIZZA SOLO CLIENTI CON COGNOME");
                Console.WriteLine("F) VISUALIZZA SOLO CLIENTI CON ETA'");
                Console.WriteLine("G) ELIMINA CLIENTE IN POSIZIONE");
                Console.WriteLine("H) ESCI");

                scelta = Console.ReadLine().ToUpper();
                switch (scelta)
                {
                    case "A":
                        {
                            inserisci_clienti();
                        }
                    break;
                    case "B":
                        {
                            aggiungi_un_cliente();
                        }
                    break;

                    case "C":
                        {
                            visualizza_sul_video_i_clienti();
                        }
                    break;

                    case "D":
                        {
                            Console.WriteLine("Inserisci il nome da cercare");
                            string nome = Console.ReadLine().ToUpper();
                            visualizza_clienti_con_nome(nome);
                        }
                     break;

                    case "E":
                        {
                            Console.WriteLine("Inserisci il cognome da cercare");
                            string cognome = Console.ReadLine().ToUpper();
                            visualizza_clienti_con_cognome(cognome);
                        }
                    break;

                    case "F":
                        {
                            Console.WriteLine("Inserisci l'età da cercare");
                            int eta = Convert.ToInt32(Console.ReadLine());
                            visualizza_clienti_con_eta(eta);
                        }
                    break;

                    case "G":
                        {
                            Console.WriteLine("Inserisci la posizione da eliminare");
                            int p = Convert.ToInt32(Console.ReadLine());
                            cancella_cliente_in_posizione(p - 1);
                        }
                    break;
                    case "H":
                        Console.WriteLine("il programma sarà terminato!");
                    break;

                    default:
                        Console.WriteLine("Non hai effettuato una scelta valida");

                    break;

                }


            } while (scelta != "H");
            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
