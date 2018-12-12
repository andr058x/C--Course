using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufficio
{
    class Program
    {     
        static void Main(string[] args)
        {
            Persona p = new Persona("Giulia", "Pavarotti", "11/11/1999");
            Console.WriteLine("Eta:" + p.GetEta()); //L'incapsulamento è la capacità di un oggetto di avere al suo interno sia attributi e metodi
            Dipendente d = new Dipendente("Mario", "Rossi", "11/11/2000", 4000);
            Console.WriteLine(d); //In realtà stiamo stampando d.ToString()
            Studente s = new Studente("Riccardo", "Cardelli", "12/02/1994", 12345);
            Persona p1 = s; //Polimorfismo: metto un oggetto di tipo studente dentro un oggetto di tipo persona
            Persona[] persone = new Persona[] { p, d, s }; //POLIMORFISMO: utilizzo studenti e dipendenti come fossero persone
            //d = s;  Errore: Uno studente non è un dipendente
            p = s; //Ok: uno studente è una persona
            int sum = 0;
            for (int i=0; i<=persone.Length-1; i++)
            {
                sum = sum + persone[i].GetEta(); //Usiamo qualcosa che ha la forma di studente/dipendente in qualcosa che è di tipo persona
            }
            Console.WriteLine("Somma:" + sum);
            Console.ReadKey();
        }
    }
}
