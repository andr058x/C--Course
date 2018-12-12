using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECLASSI  //un contenitori della classi
{
    public abstract class Automobile {  //questa è una classe astratta è non può essere istanziata ma possono ereditarla
        public virtual void Stampa() {  //virtual significa che il metodo può essere sovrascritto dalle classi figlie
      
            Console.WriteLine("Automobile");
        }

        protected int ruote = 4;  //visibile solo alle classi figlie

        protected string coloreStemma = string.Empty;
    }

    public class Bmw : Automobile //ereditarietà 
    {
        public override void Stampa()  //sovrascrittura dell'implementazione del metodo
        {
            Console.WriteLine("Bmw");
            Console.WriteLine("Numero ruote "  + ruote);
        }

        public static void StampaStatico()  //static è un metodo che può essere richiamato direttamente sulla classe a prescindere dagli oggetti (statico quando non ho bisogno di creare degli oggetti, la programamzione un tempo era tutta statica)
        {//l'oggetto è qualcosa di dinamico, se tu definisci statico appartiene solo alla classe. Se non dichiaro stati è automaticamente dinamico
            Console.WriteLine("Classe Bmw");
        }

        public new string coloreStemma = "BiancoBlu"; //questo è come un override del metodo, usiamo new perchè è solo una proprietà
    }

    class Program //Quando non metti niente è private
    {
        static void Main(string[] args)  //questo ad esempio è private perchè non scrivi niente
        {
            var bmw = new Bmw();  //istanziare un oggetto significa creare un oggetto con proprietà e comportamenti definiti nella classe

            bmw.Stampa(); //chiamo la funzione sovrascritta

            Bmw.StampaStatico();// questo viene richiamato direttamente sulla classe perchè è statico perchè dinamico si usa sugli oggetti

            Console.WriteLine(bmw.coloreStemma); //Qui stampo BiancoBlu perchè va a sovrascrivere il valore della proprietà di base, qui usia mo l'oggettto. il nome della sua proprietà.

            Console.ReadLine();
        }
    }
}
