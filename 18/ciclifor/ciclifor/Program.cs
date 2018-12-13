using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclifor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j< n; j++)
                {
                    if (i == 0 || i==n-1 || j==0 || j==n-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
