using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct1
{
    class Program
    {
        public struct dati_persona
        {
            public string nome;
            public string cognome;
            public int anni;
        }
        static void Main(string[] args)
        {
            var dp = new dati_persona();
            dp.nome = "Maurizio";
            dp.cognome = "Postiglione";
            dp.anni = 40;

            Console.WriteLine($"nome={dp.nome}");

            Console.WriteLine("inserisci, per favore, un tasto per terminare");
            Console.ReadKey();
        }
    }
}
