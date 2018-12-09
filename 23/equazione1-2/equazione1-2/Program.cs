using System;

namespace equazione1_2
{
    class Program
    {
        static float calcola_x_eq1_grado(float a, float b)
        {
            float x = -b / a;
            return x;
        }

        static void esequi_procedimento_per_eq1_grado()
        {
            Console.WriteLine("Questo programma calcolerà le equazioni di primo grado di tipo ax + b = 0");
            Console.WriteLine("Per favore inserisci il valore di a");
            float a;
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Per favore inserisci il valore di b");
            float b;
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Quindi l'equazione di cui calcolare la x è {a} + {b}=0");
            float x;
            x = calcola_x_eq1_grado(a, b);
            Console.WriteLine($"Il risultato dell'equazione è {x}");
        }
        static void Main(string[] args)
        {
            esequi_procedimento_per_eq1_grado();
            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}
