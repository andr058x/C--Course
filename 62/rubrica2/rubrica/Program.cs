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
                    
            Dictionary<String, String> rubrica = new Dictionary<string, string>(); //Dichiarazione e inizializzazione del dizionario
            
            for(int i=0; i<=contenuti.Length -1; i++)
            {
                string[] temp = contenuti[i].Split(' ');
                rubrica[temp[0]] = temp[1];
            }

            while (true)
            {
                menu();
                int scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 0:
                        goto partefinale;
                        break;
                    case 1:
                        visualizza(rubrica); //chiamo la variabile e non ho bisogno di mettere il tipo 
                        break;
                    case 2:
                        Console.Write("Inserisci il nome");
                        string nome = Console.ReadLine();
                        Console.Write("Inserisci il numero"); //il numero di telefono è sempre una stringa
                        string numero = Console.ReadLine();
                        rubrica[nome] = numero;
                        break;
                    case 3:
                        Console.Write("Inserisci il nome da eliminare");
                        string nome2 = Console.ReadLine();
                        rubrica.Remove(nome2);
                        break;
                }
            }
            partefinale:
            File.Delete("rubrica.txt");
            foreach (string k in rubrica.Keys)  //Per ogni iterazione del ciclo, k assume i valori di tutte le chiavi del dizionario una per volta esempio la prima chiave vale "Andrea" e la seconda chiave "Riccardo"
            {
                
                File.AppendAllText("rubrica.txt", k + " " + rubrica[k] + "\r\n");
            }


            Console.ReadKey();
        }

        static void menu()
        {
            Console.WriteLine("1. Visualizza rubrica");
            Console.WriteLine("2. Inserisci contatto");
            Console.WriteLine("3. Cancella contatto");
            Console.WriteLine("0. Esci dal programam");
            Console.WriteLine("Cosa scegli?");
        }
        static void visualizza(Dictionary<String, String> rubrica) // Dictionary<String, String>  tutto questo è il tipo
        {
            foreach (string k in rubrica.Keys)  //Per ogni iterazione del ciclo, k assume i valori di tutte le chiavi del dizionario una per volta esempio la prima chiave vale "Andrea" e la seconda chiave "Riccardo"
            {
                Console.WriteLine(k + ": " + rubrica[k]);  //K per esempio è Andrea e rubrica di Andrea è il numero di telefono
            }

        }

    }
}
