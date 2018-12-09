using System;

namespace ricerca
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[5];
            numeri[0] = 5;
            numeri[1] = 7;
            numeri[2] = 3;
            numeri[3] = 33;
            numeri[4] = 22;

            int x = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 0; i <=4; i++)
            {
                if (numeri[i] == x)
                {
                    Console.WriteLine($"Il numero è nella {i+1} cella");
                }
            }

            
 
            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey();
        }
    }
}
