using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aperturascritturasufile
{
    class Program
    {
        static void Main(string[] args)
        {
            string contenuti;
            contenuti = File.ReadAllText("prova.txt"); //Questa funzione restituisce tutto il contenuto di un file come una stringa
            Console.WriteLine(contenuti); //stampiamo tutto il contenuto del file

            File.WriteAllText("prova2.txt", contenuti); //Qui creo un file e ci metto dentro la stringa contenuti

            File.Delete("prova3.txt");
            for(int i=1; i<=100; i++)  //Qui scriviamo in un file tutti i numeri da 1 a 100
            {
                File.AppendAllText("prova3.txt", i + "\r\n");
            }


            List<int> lista = new List<int>();
            string contenuti2; 
            contenuti2 = File.ReadAllText("prova3.txt");

            string[] s = contenuti2.Split('\n');
            for(int i =0; i<=s.Length -1; i++)
            {
                try
                {
                    lista.Add(Convert.ToInt32(s[i]));
                }
                catch (Exception) { }
            }
            //Ora stampo la lista
            for(int i=0; i<=lista.Count -1; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
