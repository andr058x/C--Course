using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateandpublic
{
 
    public class persona // classe creata da Andrea
    {
        private string nome;
        private string cognome;
        private int anni;

        public persona() //il costruttore ha lo stesso nome della classe e viene eseguita automaticamente quando si istanzia un oggetto di questa classe
        {
            this.nome = "NON IMPOSTATO";
            this.cognome = "NON IMPOSTATO";
            this.anni = 0;
        }
        public bool set_nome(string n)
        {
            bool res=false;
            if (n.Length>=2 && n.Length<20)
            {
                this.nome = n;
                res = true;
            }
            return res;
        }

        public bool set_cognome(string c)
        {
            bool res = false;
            if (c.Length>=2 && c.Length<20)
            {
                
                this.cognome = c;
                res = true;
            }
            return res;
        }

        public bool set_eta(int e)
        {
            bool res = false;
            if (e >=0 && e < 105)
            {
                this.anni = e;
                res = true;
            }
            return res;
        }
            
        public void stampa_a_video()
        {
            Console.WriteLine($"nome={this.nome}");
            Console.WriteLine($"cognome={this.cognome}");
            Console.WriteLine($"anni={this.anni}");
        }
    }


    class Program
    {
        
        static void Main(string[] args) // Maurizio scrive il main
        {
            persona p = new persona();  // Maurizio istanzia un oggetto di tipo persona, usando la classe di Andrea

            Console.WriteLine("per favore, inserisci il nome");
            string nome = Console.ReadLine();
            if (p.set_nome(nome) == true)
            {
                Console.WriteLine("NOME IMPOSTATO");
            }
            else
            {
                Console.WriteLine("NOME NON IMPOSTATO");
            }

            Console.WriteLine("per favore, inserisci il cognome");
            string cognome = Console.ReadLine();
            if (p.set_cognome(cognome))
            {
                Console.WriteLine("COGNOME IMPOSTATO");
            }
            else
            {
                Console.WriteLine("COGNOME NON IMPOSTATO");
            }

            Console.WriteLine("per favore, inserisci l'eta'");
            int anni = Convert.ToInt32(Console.ReadLine());
            if (p.set_eta(anni))
            {
                Console.WriteLine("ETA IMPOSTATA");
            }
            else
            {
                Console.WriteLine("ETA NON IMPOSTATA");
            }
            Console.WriteLine("");
            Console.WriteLine("RIEPILOGO DATI IMPOSTATI");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            p.stampa_a_video();
            Console.WriteLine("premi un tasto per continuare");
            Console.ReadKey();

        }
    }
}
