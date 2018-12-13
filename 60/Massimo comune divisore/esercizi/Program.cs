using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizi
{
    class Program
    {

        static int MassimoComunDivisore(int a, int b)
        {
            int resto;
            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(MassimoComunDivisore(a, b));
            Console.ReadKey();

        }
    }
}
