using System;

namespace ordinanew1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quanti nomi vuoi inseire?");
            int n;
            n = Convert.ToInt32(Console.ReadLine());


            string[] nomiA;
            nomiA = new string[n];

            int i;
            for(i=0; i<=n-1; i++)

            {
                Console.WriteLine($"Inserisci {i + 1} nomi");
                nomiA[i] = Console.ReadLine();
            }

            Console.WriteLine("Stampo tutti i nomi a video");

            for(i=0; i<=n-1; i++)
            {
                Console.WriteLine($"Il nomi {i + 1} è il nomi {nomiA[i]}");
            }

            Console.WriteLine("Premi un tasto per ordinare");
            Console.ReadKey();
            for (i = 0; i <= n - 2; i++)
            {
                int j;
                for (j = i + 1; j <= n - 1; j++)
                {
                   
                    if (  string.Compare(nomiA[i], nomiA[j])  > 0)         
                    {
                        string x;
                        x = nomiA[i];
                        nomiA[i] = nomiA[j];
                        nomiA[j] = x;
                    }
                }
            }

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Il nomi {i + 1} è il nomi {nomiA[i]}");
            }
            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
