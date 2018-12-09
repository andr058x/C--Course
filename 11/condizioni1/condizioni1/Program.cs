using System;

namespace condizioni1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti anni hai?");
            /*   
             *   String annis = Console.ReadLine();
             *   int anni = Convert.ToInt32(annis);
             */
            int anni = Convert.ToInt32(Console.ReadLine());
            if (anni >= 18)
            {
                Console.WriteLine("Sei maggiorenne puoi entrare");
            }
            else
            {
                Console.WriteLine("Mi dispaice non puoi entrare perchè sei minorenne");
            }

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
