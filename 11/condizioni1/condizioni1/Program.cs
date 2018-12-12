using System;

namespace condizioni1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti anni hai?");  //Stampo a video
            

            int anni = Convert.ToInt32(Console.ReadLine());  //Prendo i dati dall'utente
            if (anni >= 18) //Verifico che questa condizone è vera
            {
                Console.WriteLine("Sei maggiorenne puoi entrare");  //Se la condizione è vera stampo questo
            }
            else
            {
                Console.WriteLine("Mi dispaice non puoi entrare perchè sei minorenne");  //Altrimenti stampo questo
            }

            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadKey();
        }
    }
}
