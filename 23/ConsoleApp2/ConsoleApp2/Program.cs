using System;

namespace ConsoleApp2
{
    class Program
    {
        static void equazionesecondogrado()
        {

            Console.WriteLine("Questo programma calcolerà le equazioni di secopndo grado di tipo ax^'2+bx+c=0");
            Console.WriteLine("Per favore inserisci il valore di a");
            double a;
        a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Per favore inserisci il valore di b");
            double b;
        b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Per favore inseirsci il valore di c");
            double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($" L'quazione da risolvere e': {a}x^2+{b}x+{c}=0");
            
            double delta = b * b - 4 * a * c;
            if (delta>0)
            {
                double x1 = -b + (Math.Sqrt(delta) / (2 * a));
        double x2 = -b - (Math.Sqrt(delta) / (2 * a));
        Console.WriteLine($" Abbiamo 2 soluxioni x1={x1} ed x2={x2}");
            }
            else if (delta==0)
            {
                double x = -b / (2 * a);
    Console.WriteLine($"Abbiamo una sola soluzione x={x}");
            }
            else
            {
                Console.WriteLine("questa equazione non ha soluzioni");
            }



        }
        static void Main(string[] args)
        {

            equazionesecondogrado();

            Console.WriteLine("Premi un tatso per terminare");
            Console.ReadKey();
        }
    }
}
