using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, k;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            Console.

            while(n!=0)
            {
                k = n % 10;
                n = n / 10;
                sum = sum + k;
            }

            Console.WriteLine("Sum digits of the number=" + sum);

            Console.ReadLine(); 
        }

    }
}
