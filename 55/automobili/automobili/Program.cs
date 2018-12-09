using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{
    class Program
    {
        public class automobile // Qui definiamo la classe automobile
        {
            private string marca;    // il parametro string marca è privato     (da fuori della classe non vi si può accedere)
            private string modello;  // il parametro string modello è privato   (da fuori della classe non vi si può accedere)
            private int cilindrata;  // il parametro int cilindrata è privato   (da fuori della classe non vi si può accedere)
            private string colore;   // il parametro string colore è privato    (da fuori della classe non vi si può accedere)

            /* vediamo la funzione statica per verificare se una marca è valida.. la facciamo statica così che si possa usare semplicemente indicando il nome della classe. Senza istanziare un oggetto  */
            public static bool marca_valida(string m) // la funzione marca_valida a cui passiamo una stringa m restituirà true se la marca è valida e false se la marca non è valida
            {
                m = m.ToUpper(); // per meglio fare i confronti tramutiamo, qualora non lo fosse già, la marca in maiuscolo
                if (m == "" || m == "FIAT" || m == "ALFA ROMEO" || m == "FERRARI" || m == "MITSUBISHI") // Se la marca è vuota, oppure "ALFA ROMEO", O "FERRARI" o "MITSUBISHI"...
                { // allora...
                    return true; // restituisci true...
                }
                else // altrimenti...
                {
                    return false; // restituisci false...
                }
            }

            /* vediamo la funzione statica per verificare se una cilidrata è valida.. la facciamo statica così che si possa usare semplicemente indicando il nome della classe.  */
            public static bool cilindrata_valida(int c)  // la funzione cilindrata_valida a cui passiamo un intero c restituirà true se la cilindrata è valida e false se la cilindrata non è valida
            {
                // Stabiliamo che la cilindrata è valida se è compresa tra 0 e 4000, 0 compreso...
                if (c >= 0 && c < 4000) // se c è nel range..
                {
                    return true;  // restituisci true...
                }
                else // altrimenti...
                {
                    return false;// restituisci false...
                }
            }

            public static bool modello_valido_per_marca(string mod, string marca) /* la funzione modello_valido_per_marca a cui passiamo due stringa mod e marca restituirà true 
                                                                                    se il modello è valido per quella marca e false se il modello non è valido per quella marca
                                                                                    */
            {   // per meglio fare i confronti tramutiamo, qualora non lo fossero già, la marca ed il modello in maiuscolo
                mod = mod.ToUpper();
                marca = marca.ToUpper();
                if (mod == "" || (mod == "PUNTO" && marca == "FIAT") || (mod == "PANDA" && marca == "FIAT") || (mod == "TESTA ROSSA" && marca == "FERRARI") || (mod == "PAJERO" && marca == "MITSUBISHI")) /*
                    In pratica controlliamo se il modello è vuoto oppure se è scritto qualcosa se è un modello valido accoppiato con la marca 
                    */
                { // se lo è... 
                    return true;// restituisci true...
                }
                else // altrimenti...
                {
                    return false; // restituisci false...
                }
            }

            /* In ultimo vediamo la funzione statica per verificare se una colore è valido.. la facciamo statica così che si possa usare semplicemente indicando il nome della classe.  */
            public static bool colore_valido(string col) // la funzione colore_valido a cui passiamo una stringa m restituirà true se la colore  è valido e false se la marca non è valida
            {
                col = col.ToUpper(); // per meglio fare i confronti tramutiamo, qualora non lo fosse già, il colore in maiuscolo
                if (col == "ROSSO" || col == "NERO" || col == "BIANCO" || col == "GRIGIO" || col == "GRIGIO METALLIZZATO" || col == "BLUE" || col == "MARRONE" || col == "VERDE" || col == "ARANCIO" || col == "GIALLO")
                {// se lo è... 
                    return true;// restituisci true...
                }
                else// altrimenti...
                {
                    return false;// restituisci false...
                }
            }
            public automobile()     // Questo è il costruttore.. Inizializza i valori delle variabili interne private
            {
                /*
                 * potremmo per azzerare i campi, agire direttamente su di essi anche se sono privati, dato che siamo DENTRO la classe stessa in cui sono definiti!
                 * Ma dato che definiamo poi delle funzioni in questa classe, che consentono di scrivere anche dall'esterno nelle variabili private, 
                 * possiamo usare quelle funzioni direttamente (così le proviamo anche)...
                 * 
                 * */
                this.set_marca("");         // Appena creato un oggetto di tipo automobile avrà la marca pari ad una stringa vuota
                this.set_modello("");       // Appena creato un oggetto di tipo automobile avrà il modello pari ad una stringa vuota
                this.set_cilindrata(0);     // Appena creato un oggetto di tipo automobile avrà la cilindrata, che è un intero, pari a 0
                this.set_colore("");        // Appena creato un oggetto di tipo automobile avrà il colore pari ad una stringa vuota
            }

            /* Le variabili private (o anche "proprietà") della classe non sono accessibili dall'esterno
             * Per cui se creiamo un oggetto di tipo automobile, poi, non si potrà accedere a i campi marca, modello, cilindrata, ecc.
             * per poterci accedere creiamo delle funzioni (o metodi). Preremiamo creare delle funzioni PUBBLICHE invece che fare pubbliche proprio le varibili,
             * perchè le funzioni, prima di mettere dei valori dentro le variabili  possono controllare che cosa sta venendo messo.
             * E queste variabili non possono contenere qualsiasi cosa, ma abbiamo deciso che CHI UTILIZZERA' questa classe per creare variabili oggetto per realizzare un programmma
             * dovrà usare delle funzioni che controllano COSA viene inserito e solo in certi casi consente di inserirlo!
             */

            // Adesso andiamo a definire quelle funzioni pubbliche di questa classe per gestire le variabili private dall'esterno
            public bool set_marca(string m) /* questa funzione servirà ad impostare il valore da mettere dentro il parametro privato marca. Alla funzione passiamo la stringa da inserire
                                             attraverso una stringa che gli si passa tra parentesi e che qui è identificata da m */
                     /* OVVIAMENTE quando impostiamo la marca, con la funzione set_marca, se mettiamo una stringa sbagliata, la funzione potrebbe non andare a buon fine..
                    * Se, per esempio, invece che FIAT, o FERRARI, o MITSUBISHI, od altre marche valide previste, mettiamo PAPERINO (facciamo una cosa tipo set_marca("paperino"), ovviamente 
                    * non funzionerà.. se invece mettiamo una marca valida, tipo FIAT, la funzione andarà bene.
                    * Però la funzione set_marca sarebbe cosa buona se alla fine ci restituisse un valore che ci indichi se l'impostazione della marca sia andata o meno a buon fine, 
                    * se la marca è stata impostata o se non era valida e quindi non lo è stata. 
                    * Per questo faremo in modo che set_marca restituisca TRUE se è andata a buon fine e FALSE se non è andata a buon fine...
                    * Una volta eseguito il comando set_marca, potremo quindi verificare cosa restituisce e vedere se è TRUE e quindi ha impostato e la marca è valida, OPPURE se è FALSE e quindi 
                    * la marca non è validaq e non l'ha impostata!
                    */
            { // a questa funzione potremo passare la stringa della marca. Per nostra scelta vogliamo che la stringa sia tutta maiuscola, anche se ci viene inserita con le minuscole...
                m = m.ToUpper(); // trasformiamo, se non lo è già, m in maiuscolo!
                /* 
                    PRIMA di inserire m come valore di marca, vediamo se m è una stringa adatta... abbiamo creato, in questa classe, anche una funzione per verificare che una stringa sia una valida marca...
                    Si tratta della funzione statica marca_valida(m) a cui passare la stringa da verificare...
                    Essendo una funzione statica non si usa con il this e neanche creando un oggetto di tipo automobile.. essendo una funzione statica si usa anteponendo il nome della classe:
                    automobile.marca_valida(m)
                    se il valore della stringa passata è una marca valida allora la funzione restituiràò un valore TRUE altrimenti restituirà un valore FALSE
                 */
                if (automobile.marca_valida(m))  // Se automobile.marca_valida(m) restituisce TRUE, e quindi l'if risulta verificato, allora il campo marca dell'oggetto può essere associato a m
                {
                    this.marca = m; // imposta la marca con m
                    /*
                     Siccome la funzione set_marca può essere utilizata ANCHE per REIMPOSTARE la marca quando è già impostata e magari è già impostato anche un modello
                     E' giusto che reimpostando la marca il modello si azzeri.. così che si sia costretti a reimpostare anche il modello. Altrimenti potrebbe anche capitare che 
                     la marca cambi e il modello no e magari la marca non è compatibile con il modello.. ad esempio, se marca="FERRARI" e modello="TESTA ROSSA", se cambio la marca e metto "FIAT"
                     é giusto che cambi anche il modello, perchè sennò rimarrebbe "TESTA ROSSA" e rischierebbe di diventare marca "FIAT" e modello "TESTA ROSSA"....
                     Quindi noi quando cambia la marca, costringiamo a reimpostare il modello azzerandolo...
                     */
                    this.set_modello(""); // Quando viene impostata la marca, per nostra scelta, abbiamo deciso che il modello deve essere azzerato

                    

                    return true; // Se siamo arrivati fin qui, vuol dire che è andato tutto bene e quindi restituiamo TRUE
                }
                else // altrimenti...
                {
                    return false; // restituiamo FALSE
                }

            }

            public string get_marca() // Siccome marca è una variabile può essere usata dall'esterno.. quindi ci serve anche una funzione per vedere che marca ci sta, che valore ha...
            {
                return this.marca; // si limita semplicemente a restituire il valore della marca...
            }

            // Dato che ANCHE IL MODELLO è un parametro privato, per inservi dentro un valore e per consultarlo serviranno delle funzioni
            public bool set_modello(string mod) // questa funzione setta il modello! Ovviamente riceve il modello da impostare nella variabile stringa mod
            {
                mod = mod.ToUpper(); // dato che non sappiamo se il modello è stato inserito minuscolo o maiuscolo x sicurezza trasponiamolo in maiuscolo
                if (this.modello_valido(mod)) // verifichiamo che il modello sia valido da impostare con la funzione modello_valido
                { // se è valido
                    this.modello = mod; //impostiamo il modello
                    return true; // restituiamo TRUE per indicare che l'assegnazione del modello è andata bene
                }
                else
                {
                    return false; // restituiamo FALSE per indicare che l'assegnazione del modello non è andata bene
                }
            }   
            public string get_modello()  // Dato che ANCHE IL MODELLO è un parametro privato, per vederlo anche soltanto dall'esterno usiamo la funzione pubblica get_modello
            {
                return this.modello;     // la funzione si limita a restituire il valore del modello..
            }
            public bool set_cilindrata(int c) /* Dato che la cilindrata è una variabile privata della classe, per metterci un valore dall'esterno useremo la funzione pubblica che creiamo qui, set_cilindrata
                                                 Alla funzione passiamo la cilindrata attraverso un valore c numerico intero...
                                                 */
            {       

                if (automobile.cilindrata_valida(c)) // usiamo la funzione statica cilindrata_valida che verifica che il valore della cilindrata che si vuole inserire sia valido
                { // se lo è...
                    this.cilindrata = c; // impostiamo la cilindrata!
                    return true;         // e restituiamo true ... 
                }
                else // altrimenti...
                    return false; // restiuitamo false...
            }
            public int get_cilindrata() // anche qui, dato che la cilindrata è una variabile privata della classe, per sapere che valore ha dall'esterno, usiamo get_cilindrata
            {
                return this.cilindrata; // restituiamo il valore della cilindrata..
            }

            // Dato che annche il colore è una variabile privata della classe, per inserci un valore usiamo una funzione
            public bool set_colore(string col) // set_colore controlla se viene passato un valore stringa valido per il colore e  se si lo imposta..
            {
                col = col.ToUpper(); // dato che non sappiamo SE il colore passato, col, è minuscolo o maiscolo, per comodità lo tramutiamo di sicuro in maiuscolo...
                if (automobile.colore_valido(col)) // Usiamo la funzione statica colore_valido per verificare che il colore inserito sia valido
                { // se lo è...
                    this.colore = col; // impostiamo il colore...
                    return true; // e restituiamo true per confermare che sia andato tutto ok
                }
                else // altrimenti... 
                    return false; // // e restituiamo false  per avvertire che qualcosa non è andato ok
            }

            public string get_colore() // infine usiamo la funzione get_colore per consultare quale valore di colore è nella variabile colore
            {
                return this.colore; // viene restituita la variabile colore
            }

            /*
             ADESSO vediamo le funzioni usate per verificare che le marche, i modelli, ecc siano validi..
                 */

            public bool modello_valido(string mod) /* Questa funzione quando la si chiama le si passa un modello (mod) e lei controlla la marca che è impostata e se il modello è compatibile con 
                                                      la marca ed è uno dei modelli della lista, allora è valido, altimenti no */
            {
                /* per verificare USIAMo la funzione statica (che poi sempre noi abbiamo creato) automobile.modello_valido_per_marca in cui si passa un modello ed una marca e lui risponde true
                   se quel modello va bene, altrimenti false... 
                   Ovviamente gli passero il modello mod passato alla funzione modello_valido e come marca gli passeremo la marca attuale   
                 */ 
                if (automobile.modello_valido_per_marca(mod, this.marca))
                {   // se è valido...
                    return true; // restutuirà true
                }
                else // altrimenti..
                { 
                    return false; // restituirà false..
                }

            }
           
            
           

            public void stampa_a_video() // Questa funzione si limita a stampare a videeo
            {
                Console.WriteLine($"MARCA: {this.marca}");
                Console.WriteLine($"MODELLO: {this.modello}");
                Console.WriteLine($"CILINDRATA: {this.cilindrata}");
                Console.WriteLine($"COLORE: {this.colore}");
            }
        }

        class gestore_automobili
        {
            public automobile[] auto;
            public gestore_automobili()
            {
                auto = new automobile[0];
            }
            public string aggiungi_auto(string marca, string modello, int cilindrata, string colore)
            {
                string res = "";
                if (automobile.marca_valida(marca))
                {
                    if (automobile.modello_valido_per_marca(modello, marca))
                    {
                        if (automobile.colore_valido(colore))
                        {
                            if (automobile.cilindrata_valida(cilindrata))
                            {
                                int c = auto.Length;
                                c++;
                                automobile[] L = new automobile[c];
                                for (int i = 0; i < c - 1; i++)
                                {
                                    L[i] = this.auto[i];
                                }
                                L[c - 1] = new automobile();
                                L[c - 1].set_marca(marca);
                                L[c - 1].set_modello(modello);
                                L[c - 1].set_cilindrata(cilindrata);
                                L[c - 1].set_colore(colore);
                                this.auto = new automobile[c];
                                for (int i=0;i<c;i++)
                                {
                                    this.auto[i] = L[i];
                                }
                            }
                            else
                            {
                                res = "CILINDRATA NON VALIDA";
                            }
                        }
                        else
                        {
                            res = "COLORE NON VALIDO";
                        }
                    }
                    else
                    {
                        res = "MODELLO NON VALIDO PER QUESTA MARCA";
                    }
                }
                else
                {
                    res = "MARCA NON VALIDA";
                }
                return res;
            }

            public void list()
            {
                int c = this.auto.Length;
                Console.WriteLine($"{c} automobili in lista: ");
                for (int i=0;i<c; i++)
                {
                    this.auto[i].stampa_a_video();
                }
            }
        }

        static void Main(string[] args)
         {
            
            gestore_automobili ga = new gestore_automobili();
            int scelta;
            do
            {
                Console.WriteLine("1 - Visualizza tutte le auto");
                Console.WriteLine("2 - Aggiungi un auto");
                Console.WriteLine("3 - Esci");
                Console.WriteLine("Effettua la tua scelta");
                scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta==1)
                {
                    ga.list();
                }
                else if (scelta==2)
                {
                    string marca;
                    string modello;
                    int cilindrata;
                    string colore;
                    
                    do
                    {
                        Console.WriteLine("Insersci la marca");
                        marca = Console.ReadLine();
                        if (!automobile.marca_valida(marca))
                        {
                            Console.WriteLine("Devi inserire una marca valida");
                        }
                    } while (!automobile.marca_valida(marca));

                    do
                    {
                        Console.WriteLine("Insersci il modello");
                        modello = Console.ReadLine();
                        if (!automobile.modello_valido_per_marca(modello, marca))
                        {
                            Console.WriteLine($"Questo modello non e' valido per la marca {marca}");
                        }
                    } while (!automobile.modello_valido_per_marca(modello, marca));

                    do
                    {
                        Console.WriteLine("Insersci la cilindrata");
                        cilindrata = Convert.ToInt32(Console.ReadLine());
                        if (!automobile.cilindrata_valida(cilindrata))
                        {
                            Console.WriteLine("Devi inserire una cindrata valida");
                        }
                    } while (!automobile.cilindrata_valida(cilindrata));

                    do
                    {
                        Console.WriteLine("Insersci il colore");
                        colore = Console.ReadLine();
                        if (!automobile.colore_valido(colore))
                        {
                            Console.WriteLine("Devi inserire un colore valido");
                        }
                    } while (!automobile.colore_valido(colore));

                    ga.aggiungi_auto(marca, modello, cilindrata, colore);


                }

            } while (scelta != 3);

            Console.WriteLine("CIAO CIAO");
            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
