using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class Program
    {
        /*
         *  Dobbiamo memorizare, visualizare, cercare e cancellare degli account. Ogni account avrà una piattaforma ("facebook", "gmail", "twiter", ecc.), un nome, un cognome, un nomeutente e una password
         *  Potremo avere 1, 5, 10, 20, 100... n account... 
         *  Quindi useremo gli array.... ma ogni cella dovrà contenere non un intero od una stringa, bensì tutte le informazioni dette sopra (una piattaforma, , un nome, un cognome, un nomeutente e una password)
         *  Una variabile che contiene tante SOTTO-VARIABILi...
         *  ogni cella dell'array dovrà essere una variabile che conterrà TANTE sotto-variabili.
         *  Ma se la cella fosse solo un intero, si dichiarerebbe con int.... se fosse una stringa si dichiarerebbe con string...
         *  Ma come dichiariamo una cella (o qualsiasi variabile) per essere capace di contenere delle sottovariabili?... usiamo le strutture, o struct..
         *  creiamo una struct (ovvero un tipo di dato nuovo, creato da noi, che definisce le sottovariabili che ogni variabile di quel tipo avrà)--
         *  
         */
        public struct accountCliente        // definiamo una struct che contenga i dati che ci servono in ogni cella dell'array, e chiamiamo questa struct accountCliente 
        {
            public string piattaforma;
            public string nome;
            public string cognome;
            public string nomeutente;
            public string password;
        }

        static accountCliente[] accountList; /* Creiamo un array, che chiameremo accountList, in cui ogni cella sarà una variabile struct di tipo accountCliente (e ciascuna di queste celle conterrà tutte le sottovaribili di accountCliente)
                                                lo facciamno fuori dal main, così tutte le funzioni ed il main stesso potranno usarla, condividendola.. per farlo la creiamo static.
                                                In questo modo, se una funzione modifica questo array, inserendo, modificando, cancellando degli account.. il main e le altre funzioni si troveranno l'array modificato...
                                            */
        static void Main(string[] args)
        {           

            accountList= new accountCliente[0]; // Un array, per poter eseguire alcune operazioni, dovrà essere istanziato. Per esempio anche solo per poter sapere quante celle ha serve istanziarlo.

            /*
             * A) Visualizza lista account
             * B) Aggiungi account
             * C) Cerca account per nome
             * D) Cerca account per cognome
             * E) Cerca account per username
             * F) Esci
             * */
            string tastoscelto; //Creo una variabile di tipo stringa
            do
            {
                Console.WriteLine("A - VISUALIZZA LISTA ACCOUNT");  //Qui creo un menu e quetso è il tasto A per visualizzare la lista degli account
                Console.WriteLine("B - AGGIUNGI ACCOUNT");   // Tasto B con questo tasto aggiungo un account
                Console.WriteLine("C - CERCA ACCOUNT PER NOME");  // Tasto C cerco un account per nome
                Console.WriteLine("D - CERCA ACCOUNT PER COGNOME");  // Tatso D cerco per cosgnome
                Console.WriteLine("E - CERCA ACCOUNT PER USERNAME");  // Tasto E cerco per username
                Console.WriteLine("F - ELIMINA UN UTENTE DALL'ELENCO IN UNA SPECIFICA POSIZIONE");
                Console.WriteLine("G - ESCI");  // Con F esco



                tastoscelto = Console.ReadLine().ToUpper();    //Qui prendo la scelta dell'utente e la concerto in maiuscolo


                int n;  //inizializzo la variabile n
                switch (tastoscelto)  //Creiamo un switch dentro come condizione c'e' il tasto scelto
                {

                    case ("A"):  //Se il tasto scelto è A si eseguono le istruzioni qui sotto
                        int i;  //creo la variabile i
                        n = accountList.Length; //recupero la lunghezza dell'array che è comunque zero perchè è stato inizializzato a zero
                        Console.WriteLine("ELENCO DEGLI ACCOUNT:");  //Scrivo a video di  inserire un elenco di account
                        for (i = 0; i < n; i++)  //Creo un ciclo for per stampare tutti gli account
                        {
                            Console.WriteLine($"Account numero {i + 1}");  //Qui stampo il numero dell'account
                            Console.WriteLine($"il cognome e' {accountList[i].cognome}");  //Qui stampo il cognome 
                            Console.WriteLine($"il nome è {accountList[i].nome}"); // Qui stampo il nome
                            Console.WriteLine($"il tuo username è {accountList[i].nomeutente}");  // Qui stampo lo username
                            Console.WriteLine($"La tua piattaforma è {accountList[i].piattaforma}"); //Qui stampo la piattaforma
                            Console.WriteLine(""); //Vado a capo

                        }
                        Console.WriteLine("FINE LISTA!"); //Qui stampo la scritta fine della lista
                        Console.WriteLine("");// Vado
                        break;  //Esce dal programma se viene eseguito il case A
                    case ("B"):

                        n = accountList.Length;  //recupero la lunghezza dell'array
                        accountCliente[] array_temp = new accountCliente[n];  //Dobbiamo creare un array temporaneo perchè aggiungendo un indice al nostro array perderemmo tutti i dati
                        for (i = 0; i <= n - 1; i++)  //Creo un ciclo for per passare tutti dati dell'array accountList nell'array array_temp
                        {
                            array_temp[i] = accountList[i];  //L'array_temp prende tutti i dati dell'accountList
                        }


                        accountList = new accountCliente[n + 1]; //Qui aggiungiamo 1 indice all'array ma perdiamo tutti i dati dentro l'array
                        for (i = 0; i <= n - 1; i++)  //Creiamo un ciclo for cosi rimettiamo tutti i dati dentro l'array
                        {
                            accountList[i] = array_temp[i]; //accountList riprende tutti i dati che c'erano dentro l'array temp
                        }

                        Console.WriteLine("Inserisci la piattaforma");  //Chiediamo i dati all'utente di inserirci un dato
                        accountList[n].piattaforma = Console.ReadLine();  //Gli chiediamo la piattaforma
                        Console.WriteLine("Inserisci il cognome");  //Scriviamo a video
                        accountList[n].cognome = Console.ReadLine(); //Chiediamo i dati all'utente di inserirci un dato
                        Console.WriteLine("Inserisci il nome"); //Scriviamo a video
                        accountList[n].nome = Console.ReadLine(); //Chiediamo i dati all'utente di inserirci un dato
                        Console.WriteLine("Inserisci la username"); //Scriviamo a video
                        accountList[n].nomeutente = Console.ReadLine(); //Chiediamo i dati all'utente di inserirci un dato
                        Console.WriteLine("Inserisci la password"); //Scriviamo a video
                        accountList[n].password = Console.ReadLine(); //Chiediamo i dati all'utente di inserirci un dato


                        break;  //Se viene eseguito il caso B con il break poi esce
                    case ("C"): //Caso C Ricerca per nome

                        Console.WriteLine("Inserisci il nome da cercare");  //Chiediamo all'utente di inserirci un nome da cercare
                        string nome = Console.ReadLine(); //Facciamo inserire all'utente il nome
                        n = accountList.Length; // Recuperiamo la lunghezza dell'array
                        Console.WriteLine(""); //Con questo andiamo a capo
                        Console.WriteLine($"Elenchiamo tutti gli account con per nome {nome}");
                        for(i=0; i<=n-1; i++)  //Ciclo for per stampare la lista degli account che sono stati trovati
                        {
                           
                            if (accountList[i].nome == nome) // if accountList[i].nome == nome entra dentro l'if
                            {
                                Console.WriteLine($"Account numero {i + 1}"); //Stampiamo il numeri dell'account utente
                                Console.WriteLine($"il cognome e' {accountList[i].cognome}"); //Stampiamo Il cognome
                                Console.WriteLine($"il nome è {accountList[i].nome}");  //Stampiamo il nome
                                Console.WriteLine($"il tuo username è {accountList[i].nomeutente}"); // Stampiamo la username
                                Console.WriteLine($"La tua piattaforma è {accountList[i].piattaforma}");  //Stampiamo la piattaforma
                                Console.WriteLine("");  //Andiamo a capo
                            }
                        }
                        Console.WriteLine("Elenco finito");  //Scriviamo a video che l'elenco è finito
                        Console.WriteLine(""); //Andiamo a capo


                        break; //Istruzione break per uscire dallo switch
                    case ("D"): //Caso D è cercare un utente dal cognome
                        Console.WriteLine("Inserisci il cognome da cercare");  //Scriviamo a video di inserirci il cognome da cercare
                        string cognome = Console.ReadLine();  //  Creiamo una variabile stringa e ci facciamo inserire all'utente il cognome da cercare
                        n = accountList.Length;  // Recuperiamo la lunghezza dell'array
                        Console.WriteLine("");  //Andiamo a capo
                        Console.WriteLine($"{n} account trovati:");  //Scriviamo a video quanto account abbiamo trovato
                        Console.WriteLine($"Elenchiamo tutti gli account con per cognome {cognome}");  //Scriviamo che elenchiamo tutti gli account trovati per quel cognome
                        for (i = 0; i <= n - 1; i++)  //Ciclo for per stampare tutti gli account trovati
                        {
                            
                            if (accountList[i].cognome == cognome) //Condizione if se abbiamo trovato l'account non entra nell'if se nessun account è stato trovato
                            {
                                Console.WriteLine($"Account numero {i + 1}");  // Scriviamo a video il numero dell'account
                                Console.WriteLine($"il cognome e' {accountList[i].cognome}"); //Scriviamo a video il cognome
                                Console.WriteLine($"il nome è {accountList[i].nome}");  //Scriviamno a video il nome
                                Console.WriteLine($"il tuo username è {accountList[i].nomeutente}");  // Scriviamo a video lo username
                                Console.WriteLine($"La tua piattaforma è {accountList[i].piattaforma}"); //Scriviamo a video la piattaforma
                                Console.WriteLine("");  //Andiamo a capo
                            }
                        }
                        Console.WriteLine("Elenco finito");  //Scriviamo Elenco finito fuori dal ciclo for
                        Console.WriteLine(""); //Andiamo a capo



                        break;  //Con il break usciamo dallo swicth
                    case ("E"):  //Con il caso E facciamo una ricerca tramite lo username
                        Console.WriteLine("Inserisci lo username da cercare");  //Scriviamo a video di inserire lo username da cercare
                        string username = Console.ReadLine(); //Creiamo una variabile e ci facciamo inserire dall'utente l,o username da cercare
                        n = accountList.Length;  //Recuperiamo la lunghezza dell'array
                        Console.WriteLine("");  //Andiamo a capo
                        Console.WriteLine($"{n} account trovati:"); //Scriviamo quanto account abbiamo trovato
                        Console.WriteLine($"Elenchiamo tutti gli account con per username {username}");  //Stampiamo la scritta a video che elencheremo tutti gli account trovati
                        for (i = 0; i <= n - 1; i++)  //Facciamo un ciclo for per stampare gli account trovati
                        {
                           
                            if (accountList[i].nomeutente == username) // Entriamo nell'if se l'account è stato trovato ed eseguiamo le successive istruzioni
                            {
                                Console.WriteLine($"Account numero {i + 1}");   //Stampiamo il numero degli account trovati
                                Console.WriteLine($"il cognome e' {accountList[i].cognome}");  //Stampiamo il cognome
                                Console.WriteLine($"il nome è {accountList[i].nome}");  //Stampiamo il nome
                                Console.WriteLine($"il tuo username è {accountList[i].nomeutente}");  //Stampiamo lo username
                                Console.WriteLine($"La tua piattaforma è {accountList[i].piattaforma}");  //Stampiamo la piattaforma
                                Console.WriteLine(""); //Andiamo a capo
                            }
                        }
                        Console.WriteLine("Elenco finito"); // STampiamo la scritta elenco finito
                        Console.WriteLine("");  //Andiamo a capo
                        break;

                    case ("F"):

                        Console.WriteLine("Quale posizione vuoi cancellare?");
                        int p = Convert.ToInt32(Console.ReadLine())-1;
                        

                        n = accountList.Length;

                        if (p >= 0 && p<n)
                        {
                            int j = 0;
                            array_temp = new accountCliente[n - 1];  //Dobbiamo creare un array temporaneo perchè aggiungendo un indice al nostro array perderemmo tutti i dati
                            for (i = 0; i <= n - 1; i++)  //Creo un ciclo for per passare tutti dati dell'array accountList nell'array array_temp
                            {
                                if (i != p)
                                {
                                    array_temp[j] = accountList[i];  //L'array_temp prende tutti i dati dell'accountList
                                    j++;
                                }
                            }


                            accountList = new accountCliente[n - 1]; //Qui aggiungiamo 1 indice all'array ma perdiamo tutti i dati dentro l'array
                            for (i = 0; i <= n - 2; i++)  //Creiamo un ciclo for cosi rimettiamo tutti i dati dentro l'array
                            {
                                accountList[i] = array_temp[i]; //accountList riprende tutti i dati che c'erano dentro l'array temp
                            }

                            Console.WriteLine("L'account è stato eliminato");
                        }
                        else
                        {
                            Console.WriteLine($"Per eliminare la posizione scelta deve essere interna a quelle degli account (da 1 a {n})");
                        }

                           

                        break;


                }
            } while (tastoscelto != "G"); //Ciclo while se il tasto premuto è diverso da f riparte con tutto il programma


            Console.WriteLine("Premi un tasto per terminare"); //Terminare il programma
            Console.ReadKey();

        }

    }
}
