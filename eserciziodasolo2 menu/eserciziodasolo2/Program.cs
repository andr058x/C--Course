using System;

namespace oplist1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numeri = new int[0]; 
            string scelta;
            do
            {
                Console.WriteLine("Scegli una opzione");
                Console.WriteLine("A) inserisci numeri");
                Console.WriteLine("B) Somma i numeri inseriti");
                Console.WriteLine("C) Fai la media dei numeri inseriti");
                Console.WriteLine("D) Moltiplica i nmeri inseriti tra loro");
                Console.WriteLine("E) Esci");
                scelta = Console.ReadLine().ToUpper();

                if (scelta == "A") 
                {
                    Console.WriteLine("Quanti numeri vuoi inseire?"); 
                    int n = Convert.ToInt32(Console.ReadLine()); 
                    numeri = new int[n];  
                    int i;  
                    for (i = 0; i <= n - 1; i++) 
                    {
                        Console.WriteLine($"Inserisci il {i + 1} numero");  
                        numeri[i] = Convert.ToInt32(Console.ReadLine()); 
                    }

                }
                else if (scelta == "B") 
                {
                   
                    int n = numeri.Length; 
                    int s = 0; 
                    for (int i = 0; i <= n - 1; i++) 
                    {
                        s = s + numeri[i];
                    }
                    
                    Console.WriteLine($"La somma e': {s}");

                }
                else if (scelta == "C")
                {
                
                    int n = numeri.Length;
                    int i;  
                             
                    int s = 0; 
                    for (i = 0; i <= n - 1; i++) 
                    {
                        s = s + numeri[i];
                    }
                   
                    double media = s / n; 
                    
                    Console.WriteLine($"La media e': {media}"); 
                }
                else if (scelta == "D") 
                {
                    int n = numeri.Length;                  
                    int m = 1;  
                    for (int i = 0; i <= n - 1; i++) 
                    {
                        m = m * numeri[i]; 
                    }
                    Console.WriteLine($"La moltiplicazione è : {m}"); 
                }

            } while (scelta != "E");


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
