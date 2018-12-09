using System;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eta;
            eta = new int[10];
            int i;
            for (i=0; i<10; i++)
            {
                Console.WriteLine($"Inserisci il {i+1} numero");
                eta[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (i=0; i<10; i++)
            {
                Console.WriteLine(eta[i]);
            }
           
            Console.WriteLine("Premi un tasto!");
            Console.ReadKey();
        }
    }
}
