using System;

namespace cambioarraystringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            do
            {
                Console.WriteLine("Quante parole vuoi inserire?");
                int n;
                n = Convert.ToInt32(Console.ReadLine());

                string[] frasiA;
                frasiA = new string[n];

                string[] frasiB;
                frasiB = new string[n];

                int i;
                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Inserisci {i + 1} parole");
                    frasiA[i] = Console.ReadLine();
                }
                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Inserisci {i + 1} parole");
                    frasiB[i] = Console.ReadLine();
                }

                Console.WriteLine("Stampo a video frasiA");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"La parola {i + 1} è la parola {frasiA[i]}");
                }
                Console.WriteLine("Stampo a video frasiB");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"La parola {i + 1} è la parola {frasiB[i]}");
                }

                Console.WriteLine("Adesso invertiamo le parole");

                string x;

                for (i = 0; i <= n - 1; i++)
                {
                    x = frasiA[i];
                    frasiA[i] = frasiB[i];
                    frasiB[i] = x;
                }

                Console.WriteLine("Stampo a video frasiA");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"La parola {i + 1} è la parola {frasiA[i]}");
                }
                Console.WriteLine("Stampo a video frasiB");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"La parola {i + 1} è la parola {frasiB[i]}");
                }
                
                do
                {
                    Console.WriteLine("Vuoi ricominciare? [SI/NO]");
                    risposta = Console.ReadLine().ToUpper();

                } while (risposta != "SI" && risposta != "NO");

            } while (risposta == "SI");

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
