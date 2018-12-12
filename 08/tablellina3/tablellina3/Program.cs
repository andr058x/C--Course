using System;

namespace tablellina3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;
            for (i = 1; i <= 10; i++)  //Ciclo for
            {
                n = 3 * i;
                Console.WriteLine($"3x{i}={n}");  //Sintassi per scrivere dentro le parentesi
            }
        

            Console.WriteLine("Premi un tasto per continuare!");
            Console.ReadKey();
        }
    }
}
