using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    class Program
    {
        static bool numeriPrimi(int n)
        {
            
            int i;
            bool check = false;
            for (i = 2; i <= n - 1; i++)
            {
                if (n % i == 0) //Se n è divisibile per i
                {
                    // Console.WriteLine("Non è primo"); 
                    check = true; // Se check è true allora il numero non è primo
                    break;
                }

            }

            if (check == true)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        static void Main(string[] args) {
                   
            Console.WriteLine("Ti ricordo quali numeri sono primi da 1 a 100");

            List<int> lista = new List<int>();
            lista.Add(1);
            for(int i=1; i<=100; i++){       
                if(numeriPrimi(i))
                {
                    Console.WriteLine(i);
                    lista.Add(i);                  
                }
            }
            lista[2] = 300;
            Console.ReadKey();
        }
    }
}
