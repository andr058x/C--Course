using System;

namespace prove_variabili4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prover vaiabili 4!"); //Stampo a video
            String nome;  //Creo una varoiabile nome
            Console.WriteLine("Inserisci il tuo nome:");
            nome = Console.ReadLine(); // Questo comando serve a permettere l'inserimento da parte dell'utente, del suo nome che viene memorizzato così nella variabile nome
            Console.Write("Ciao ");  //Stampo a video senza andare a capo
            Console.WriteLine(nome);  //Stampo la variabile nome
            Console.WriteLine("Adesso premi un tasto per terminare il programma");  //Stampo a video una scritta
            Console.ReadKey();
        }
    }
}
