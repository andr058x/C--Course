using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persone;
            int n = 5;
            persone = new string[n];
            int i;
            for (i = 0; i <= n-1; i++)
            {
                Console.WriteLine($"Inserisci la {i + 1} persona");
                persone[i] = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Adesso riepiloghiamo");
            for (i = 0; i <= n-1; i++)
            {
                Console.Write($" La {i + 1} persona e' {persone[i]},  ");
            }

            Console.WriteLine("inserisci il nome da cercare");
            string nome = Console.ReadLine().ToUpper();

            bool trovato = false;
            i = 0;
            while (i<=n-1 && trovato==false)
            {
                if (persone[i]==nome)
                {
                    trovato = true;
                }
                else
                {
                    i++;
                }
            }
            if (trovato==true)
            {
                Console.WriteLine($" il nome c'è ed è presente alla posizione numnero {i+1}");
            }
            Console.WriteLine("premi un tasto!");
            Console.ReadKey();
        }
    }
}
