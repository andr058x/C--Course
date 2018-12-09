using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2
{
    class Program
    {
        public struct cliente
        {
            public string nome;
            public string cognome;
            public int eta;


        }
        static void Main(string[] args)
        {

            cliente c1 = new cliente();
            cliente c2 = new cliente();
            cliente c3 = new cliente();

            Console.WriteLine("Inseriamo i dati del primo cliente");
            Console.WriteLine("inserisci il nome");
            c1.nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome");
            c1.cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            c1.eta = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Inseriamo i dati del secondo cliente");
            Console.WriteLine("Inserisci il nome");
            c2.nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome");
            c1.cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            c2.eta = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Inseriamo i dati del terzo cliente");
            Console.WriteLine("Inserisci il nome");
            c2.nome = Console.ReadLine();
            Console.WriteLine("inserisci il cognome");
            c1.cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            c2.eta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adesso visualizziamo i dati del primo cliente");
            Console.WriteLine($"Nome: {c1.nome}");
            Console.WriteLine($"Cognome: {c1.cognome}");
            Console.WriteLine($"Età: {c1.eta}");

            Console.WriteLine("Adesso visualizziamo i dati del secondo cliente");
            Console.WriteLine($"Nome: {c2.nome}");
            Console.WriteLine($"Cognome: {c2.cognome}");
            Console.WriteLine($"Età: {c2.eta}");

            Console.WriteLine("Adesso visualizziamo i dati del terzo cliente");
            Console.WriteLine($"Nome: {c3.nome}");
            Console.WriteLine($"Cosgnome: {c3.cognome}");
            Console.WriteLine($"Età: {c3.eta}");


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
