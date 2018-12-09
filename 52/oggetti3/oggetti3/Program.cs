using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oggetti3
{
    class Program
    {
        class auto  // creiamo una struttura e all'interno mettiamo degli oggetti
        {
            public string marca;  //creiamo l'oggetto marca
            public string modello; //creiamo l'oggetto modello
            public int anno;  //creiamo l'oggetto anno
            public int cilindrata; //creaimo l'oggetto cilindrata
            public void azzera()   //qui creiamo una funzione dentro la struttura che va ad azzerare gli oggetti
            {
                this.anno = 0;  // usiamo this per andare ad azzerare l'oggetto interno anno
                this.cilindrata = 0; // usiamo this per andare ad azzerare l'oggetto interno cilindrata
                this.modello = "";  // usiamo this per andare ad azzerare l'oggetto interno modelo
                this.marca = ""; // usiamo this per andare ad azzerare l'oggetto interno marca
            }
            public void fatti_inserire_dati()
            {
                Console.WriteLine("Inserisci la marca");
                this.marca = Console.ReadLine();
                Console.WriteLine("Inserisci il modello");
                this.modello = Console.ReadLine();
                Console.WriteLine("Inserisci l'anno");
                this.anno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la cilindrata");
                this.cilindrata = Convert.ToInt32(Console.ReadLine());
            }

            public void stampa_a_video()
            {
                Console.WriteLine($"La marca è {this.marca}");  //andiamo a stampare a video l'oggetto
                Console.WriteLine($"Il modello è {this.modello}"); //andiamo a stampare a video l'oggetto
                Console.WriteLine($"L'anno è {this.anno}"); //andiamo a stampare a video l'oggetto
                Console.WriteLine($"La cilindrata è {this.cilindrata}"); //andiamo a stampare a video l'oggetto
            }
        }
        static void Main(string[] args)  //abbiamo creato la struttura fuori dal main adesso andiamo a lavorare sui dati dentro il main
        {

            auto x;  //dichiariamo l'oggetto
            x = new auto();  //istanziamo l'oggetto 
            x.fatti_inserire_dati();

            Console.WriteLine("Premi un tasto per continuare");  //blocchiamo il programma per leggere
            Console.ReadKey();  //pressione di un tasto della tastiera

            Console.WriteLine("Riepilgando");  //scriviamo a video avvisando che andremo a stampare

            x.stampa_a_video();

            Console.WriteLine("Premi un tasto per continuare"); //blocchiamo il programma per leggere
            Console.ReadKey(); //pressione di un tasto della tastiera
            x.azzera();  //chiamiamo la funzione che è stata scritta dentro la struct che andrà ad azzerare tutti i nostri dati

            Console.WriteLine("Riepilgando di nuovo... ora che è stata azzerata");  //avvisiamo l'utente che stamperemo di nuovo i dati

            x.stampa_a_video();

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
