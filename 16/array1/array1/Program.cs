using System;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eta; //Crero un array
            eta = new int[10]; //Istanzio un array
            int i;  //Dichiaro una variabile
            for (i=0; i<10; i++)  //Ciclo for per prenderei numeri
            {
                Console.WriteLine($"Inserisci il {i+1} numero");  
                eta[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (i=0; i<10; i++)  //Ciclo for per stampare i numeri
            {
                Console.WriteLine(eta[i]);
            }
           
            Console.WriteLine("Premi un tasto!");
            Console.ReadKey();
        }
    }
}
