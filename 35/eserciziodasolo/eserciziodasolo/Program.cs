using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta = "no";
            do
            {


                Console.WriteLine("Quanti numeri vuoi inserire?");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] casellaA;
                casellaA = new int[n];

                int[] casellaB;
                casellaB = new int[n];

                int i;
                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Inserisci {i + 1} numeri");
                    casellaA[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Inserisci {i + 1} numeri");
                    casellaB[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Stampo a video i primi numeri");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Il {i + 1} è il numero {casellaA[i]}");
                }

                Console.WriteLine("Stampo a video gli altri numeri");

                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine($"Il {i + 1} è il numero {casellaB[i]}");
                }


               

                
                do
                {

                    Console.WriteLine("Vuoi rieseguire il programma? inserisci 'SI' oppure 'No'");
                    risposta = Console.ReadLine().ToUpper();

                } while (risposta != "SI" && risposta != "NO");

            }
            while (risposta == "SI");





            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
