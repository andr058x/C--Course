using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarieta
{
    class Program
    {
        public class persona
        {
            private string nome;
            public string cognome;
            public string indirizzo;
            public bool set_nome(string n)
            {
                bool res = false;
                if (n.Length>=4)
                {
                    this.nome = n;
                    res = true;
                }
                return res;
            }

            public void azzera_nome()
            {
                    this.nome = "";
            }

            public string gestnome()
            {
                return this.nome;
            }
            public void stampa_indirizzo()
            {
                Console.WriteLine(this.indirizzo);
            }

            public void stampa_nominativo()
            {
                Console.WriteLine($"{this.nome} {this.cognome}");
            }
            public void azzera()
            {
                this.nome = "";
                this.cognome = "";
                this.indirizzo = "";
            }

            
            public void stampa_a_video()
            {
                this.stampa_nominativo();
                this.stampa_indirizzo(); ;

            }

        }

        public class calciatore: persona
        {
            public string squadra;
            public int numero;
            public void azzera()
            {
                this.azzera_nome();
                this.cognome = "";
                this.indirizzo = "";
                this.squadra = "";
                this.numero = 0;
            }

            public void stampa_a_video()
            {

                this.stampa_nominativo();
                this.stampa_indirizzo();
                Console.WriteLine($"squadra: {this.squadra}");
                Console.WriteLine($"numero: {this.numero}");

            }
        }

        static void Main(string[] args)
        {
            calciatore c = new calciatore();
            Console.WriteLine("inserisci il nome");
            c.set_nome(Console.ReadLine());
            Console.WriteLine("inserisci il cognome");
            c.cognome = Console.ReadLine();
            Console.WriteLine("inserisci l'indirizzo");
            c.indirizzo = Console.ReadLine();
            Console.WriteLine("Inserisci la squadra");
            c.squadra = Console.ReadLine();
            Console.WriteLine("inserisci il numero di squadra");
            c.numero = Convert.ToInt32(Console.ReadLine());
            persona d = new persona();
          

            Console.WriteLine("premi un tasto per riepologare i dati del calciatore");
            c.stampa_a_video();

            Console.WriteLine("premi un tasto per continuare");
            Console.ReadKey();
           
        }
    }
}
