using System;

namespace tablellina3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;
            for (i = 1; i <= 10; i++)
            {
                n = 3 * i;
                Console.WriteLine($"3x{i}={n}");
            }
        

            Console.WriteLine("Premi un tasto per continuare!");
            Console.ReadKey();
        }
    }
}
