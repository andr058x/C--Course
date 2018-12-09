using System;

namespace cicli02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=1; i<=10; i++)
            {
                Console.Write("i=");
                Console.WriteLine(i);
            }
            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey();
        }
    }
}
