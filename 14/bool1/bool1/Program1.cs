using System;

namespace bool1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci un numero");
            int n= Convert.ToInt32(Console.ReadLine());

            bool confronto = (n > 10);

            if(confronto)
            {
                Console.WriteLine("Il tuo numero è maggiore di 10");
            }
            else
            {
                Console.WriteLine("Il tuo numero è minore di 10");
            }


            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
