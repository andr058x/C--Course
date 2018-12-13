using System;
using System.Collections.Generic;
using System.IO; //Aggiungere questo quando devo scrivere o leggere files
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rubrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contenuti; //creiamo un array che rappresenta le linee del file
            contenuti = File.ReadAllLines("rubrica.txt");  //restituisco le linee del file come un array di stringhe - FileReadaAllLines inizializza anche l'array
            //facendo contenuti.length ottengo il numero di linee nel file
            //La prima linea del file la prendo facendo contenuti[0]
            String[] record = contenuti[0].Split(' '); //vado a separare Andrea e il suo numero
            Console.WriteLine(record[0]); //Qui stampo  Andrea
            Console.WriteLine(record[1]); //Qui stampo il numero di Andrea
            String[] record2 = contenuti[1].Split(' ');  //vado a separare Riccardo e il suo numero
            Console.WriteLine(record2[0]);//Qui stampo  Riccardo
            Console.WriteLine(record2[1]);//Qui stampo il numero di Riccardo
            Dictionary<String, String> rubrica = new Dictionary<string, string>(); //Dichiarazione e inizializzazione del dizionario
            //Console.WriteLine(contenuti); 
            rubrica[record[0]] = record[1];
            rubrica[record2[0]] = record2[1];
            foreach(string k in rubrica.Keys)  //Per ogni iterazione del ciclo, k assume i valori di tutte le chiavi del dizionario una per volta esempio la prima chiave vale "Andrea" e la seconda chiave "Riccardo"
            {
                Console.WriteLine(k + ": " + rubrica[k]);  //K per esempio è Andrea e rubrica di Andrea è il numero di telefono
            }



            Console.ReadKey();
        }
    }
}
