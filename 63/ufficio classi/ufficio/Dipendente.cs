using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ufficio
{
    class Dipendente: Persona
    {
        //ATTRIBUTI
        float salario;


        //METODI
        public Dipendente(string nome, string cognome, string nascita, float salario): base(nome, cognome, nascita)//Costruttore e con base chiamo il costruttore del padre
        {
            this.salario = salario;
        }
        public override string ToString() //fare restituire tutto
        {
            return base.nome + "," + base.cognome + "," + base.nascita + "," + salario;
        }
    }
}
