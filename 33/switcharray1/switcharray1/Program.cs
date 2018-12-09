using System;

namespace switcharray1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeriA;
            numeriA = new int[5];

            int[] numeriB;
            numeriB = new int[5];

            int i;
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Inserisci {i + 1} numeri");
                numeriA[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Inserisci {i + 1} numeri");
                numeriB[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("visualizzazione numeriA");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"I primi {i + 1} numero sono {numeriA[i]}");
            }
            Console.WriteLine("visualizzazione numeriB");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Gli altri {i + 1} numero sono {numeriB[i]}");
            }

            Console.WriteLine("invertiamo!");
            int x;

            for (i=0; i<=4; i++)
            {
                x = numeriA[i];
                numeriA[i] = numeriB[i];
                numeriB[i] = x;
            }

            Console.WriteLine("rivisualizziamo");
            Console.WriteLine("visualizzazione numeriA");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"I primi {i + 1} numero sono {numeriA[i]}");
            }
            Console.WriteLine("visualizzazione numeriB");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Gli altri {i + 1} numero sono {numeriB[i]}");
            }

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
