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
            Console.WriteLine("Inserisci un numero");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != -1) //Modificare in modo che la condizione di uscita sia qui dentro
            {    
                lista.Add(num);
                Console.WriteLine("Inserisci un numero");
                num = Convert.ToInt32(Console.ReadLine());
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
