using System;

namespace saltifor
{
    class Program
    {
        static float calcola_ipotenusa(float cat1, float cat2)
        {
            float quad1 = cat1 * cat1;
            float quad2 = cat2 * cat2;
            return (float)Math.Sqrt(quad1 + quad2);
        }
        static void Main(string[] args)
        {
            float a; //creaimo la variabile a per inserire il primo cateto
            float b;  // creaimo la variabile b per inseirire il secondo cateto
            float c;   //creiamo la variabile c per eseguire il calcoo matematico
            string risposta;
            do
            {

                Console.WriteLine("Inserisci il primo cateto");  //chiediamo all'utente di inserire il valore del primo cateto
                a = Convert.ToSingle(Console.ReadLine());  //convertiamo il valore del primo cateto da una stringa a un numero con la virgola
                Console.WriteLine("Inserisci il secondo cateto"); //chiediamo all'utente l'inserimento del secondo cateto
                b = Convert.ToSingle(Console.ReadLine()); //convertiamo il valore del primo cateto da una stringa a un numero con la virgola           
                c = calcola_ipotenusa(a, b);

                Console.WriteLine($"La lunghezza dell'ipotenusa e' {c}");  //scrivo a video il risultato

                ripeti:

                Console.WriteLine("Vuoi fare la stessa cosa? Si o no?");  //chiediamo all'utente se vuole rieseguire il programma
                risposta = Console.ReadLine();  //qui chiediamo all'utente di inserire si o no
                risposta = risposta.ToUpper();  //convertiamo la risposta in lettere maiuscole
                if (risposta != "SI" && risposta != "NO")
                {
                    goto ripeti;
                }



            } while (risposta == "SI");

            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}