using System;

namespace ricerca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numeri;
            numeri = new int[n];

            int i;
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Inserisci il 1 numero");
                numeri[i] = Convert.ToInt32(Console.ReadLine());

            }        
            for (i=0; i<= n-1; i++)
            {
                Console.WriteLine($"Il {i +1}  numero è {numeri[i]}");
            }

            Console.WriteLine("Quale numero vuoi cercare?");
            int x = Convert.ToInt32(Console.ReadLine());
/*
           
            i = 0;
            bool trovato = false;
            while (trovato==false && i<=n-1)
            {
                if (numeri[i]==x)
                {
                    trovato = true;
                }
                else
                {
                    i++;
                }
            }

            if (trovato == true)
            {
                Console.WriteLine("Il numero è presente");
            }
            else
            {
                Console.WriteLine("Il numero non è stato trovato");
            }

             */
/*
            int c = 0;
            for (i=0; i<=n-1; i++)
            {
                if (numeri[i]==x)
                {
                    c++;
                }
               
            }
            */

            int c = 0;
            i = 0;
            while  (i<=n-1)
            {
                if (numeri[i]==x)
                {
                    c++;
                }
                i++;
            }


            if (c==0)
            {
                Console.WriteLine("Il numero non è presente nella lista");
            }
            else
            {
                Console.WriteLine($"Ci sono {c} numeri corrispondenti");
            }

          /*  */


            Console.WriteLine("Premi per terminare");
            Console.ReadKey();
        }
    }
}
