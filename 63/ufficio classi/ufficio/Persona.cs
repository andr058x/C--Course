using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufficio
{
    class Persona  //Creiamo una classe padre con i suoi attributi e i suoi metodi
    {
        //Esempi di classe che potrebbero estendere persona: Viaggiatore, Calciatore, Dirigente, Professore, ecc
        //ATTRIBUTI
        public string nome;
        public string cognome;
        public string nascita;

        //METODI
        public Persona(string nome, string cognome, string nascita)//Il costruttore segue 3 regole: E' sempre public, ha lo stesso nome della classe e non ha tipo di ritorno.
        {
            this.nome = nome;  //Con this.attributo prendo gli attributi della classe, altrimenti prendo i parametri del costruttore
            this.cognome = cognome; //Qui stiamo facendo this.cognome = "Cardelli"
            this.nascita = nascita;
        }
        public int GetEta()
        {
            // Formato di nascita: "11/11/1999" 
            string anno = nascita.Split('/')[2];
            int Anno = Convert.ToInt32(anno);
            return 2018 - Anno;
        }
        public override string ToString()//Utilizziamo override per sovrascrivere il ToString presente nella classe Object
        {
            return nome + "," + cognome + "," + nascita;
        }
    }
}
