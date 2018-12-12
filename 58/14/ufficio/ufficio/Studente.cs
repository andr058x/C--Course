using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufficio
{
    class Studente: Persona
    {
        int matricola;

        public Studente(string nome, string cognome, string nascita, int matricola) : base(nome, cognome, nascita) //Costruttore. 
        {
            this.matricola = matricola;
        }
        public override string ToString()
        {
            return nome + "," + cognome + "," + nascita + "," + matricola;
        }

    }
}
