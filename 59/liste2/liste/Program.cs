using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quante persone vuoi inserire?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> lista = new List<string>();  //La lista la inizializzo sempre come vuota
            
            for(int i=0; i<=n-1; i++)
            {
                Console.WriteLine("Inserisci un nome");
                lista.Add(Console.ReadLine()); //Add non vuole l'uguale     
            }
            Console.WriteLine("Questa è la lista delle persone");  //Fuori dal for perchè va ripetuto una sola volta
            for(int i=0; i<=n-1; i++)
            {
                Console.WriteLine(lista[i]); //L'elemento iesimo della lista lo prendo con l'istruzione lista[i]
            }

            Console.ReadKey();
        }
    }
}
