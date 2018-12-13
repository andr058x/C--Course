using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i numeri positivi interi quando ti sei stancato inserisci -1");
            List<int> lista = new List<int>();
            int num = 0;
            while(true) //Modificare in modo che la condizione di uscita sia qui dentro
            {
                Console.WriteLine("Inserisci un numero");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == -1) {
                    break;
                }
                lista.Add(num);
            }
            Console.WriteLine("Min:"+ lista.Min());
            Console.WriteLine("Max:" + lista.Max());
            Console.WriteLine($"Max:{lista.Max()}");
            Console.WriteLine("Media:" + lista.Average());
            int range = lista.Max() - lista.Min();
            Console.WriteLine("Range:" + range);
            Console.WriteLine("Somma:" + lista.Sum());
            lista.Sort();
            Console.Write("Ordinata:");
            for(int i=0; i<=lista.Count-1; i++)
            {
                Console.Write(lista[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
