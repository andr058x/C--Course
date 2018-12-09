using System;

namespace tabellina2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            for (i=1; i<=10; i++)
            {
                n = 2 * i;
                Console.WriteLine($"2x{i}={n}");
            }
            

            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey(); ;
        }
    }
}
