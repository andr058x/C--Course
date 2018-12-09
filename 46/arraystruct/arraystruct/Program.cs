using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraystruct
{
    public struct cliente
    {
        public string nome;
        public string cognome;
        public int eta;
    }
    static void Main(string[] args)
    {
        
      
        cliente[] array_di_clienti = new cliente[5];
        int i;
        for (i=0; i<=5; i++)
        {
            Console.WriteLine($"inseriamo i dati del {i + 1} cliente");
            Console.WriteLine("Insersci il nome");
            array_di_clienti[i].nome = Console.ReadLine();
            array_di_clienti[i].cognome = Console.ReadLine();
            array_di_clienti[i].eta = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Adesso visualizziamo l'intera lista di clienti");
        for (i=0; i<=5; i++)
        {
            Console.WriteLine($"{i + 1}-mo cliente");
            Console.WriteLine($"NOME: {array_di_clienti[i].nome}");
            Console.WriteLine($"COGNOME: {array_di_clienti[i].cognome}");
            Console.WriteLine($"ETA': {array_di_clienti[i].eta}");

        }
       

        Console.WriteLine("Premi un tasto per terminare");
        Console.ReadKey();
    }
}
