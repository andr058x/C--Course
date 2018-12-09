using System;

namespace pitagora
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
            inizio: // torniamo in questo punto se l'utente vuole rieseguire il programma
            Console.WriteLine("Inserisci il primo cateto");  //chiediamo all'utente di inserire il valore del primo cateto
            a = Convert.ToSingle(Console.ReadLine());  //convertiamo il valore del primo cateto da una stringa a un numero con la virgola
            Console.WriteLine("Inserisci il secondo cateto"); //chiediamo all'utente l'inserimento del secondo cateto
            b = Convert.ToSingle(Console.ReadLine()); //convertiamo il valore del primo cateto da una stringa a un numero con la virgola           
            c = calcola_ipotenusa(a, b);

            Console.WriteLine($"La lunghezza dell'ipotenusa e' {c}");  //scrivo a video il risultato

            ripartenza:  //il programam riparte da qui se la risposta dell'utente è diversa da si o da no

            Console.WriteLine("Vuoi fare la stessa cosa? Si o no?");  //chiediamo all'utente se vuole rieseguire il programma
            string risposta = Console.ReadLine();  //qui chiediamo all'utente di inserire si o no
            risposta = risposta.ToUpper();  //convertiamo la risposta in lettere maiuscole
            if (risposta!="SI" && risposta!="NO")  // facciamo un if per verificare che risposta sia diversa da si o da no
            {
                goto ripartenza;  //rimandiamo il programam a ripartenza nel caso la risposta fosse diversa da si o da no
            }

            if (risposta== "SI"){  //se invece la risposta è si entra dentro questo if

                goto inizio;  //è va a inizio
            }


            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}

