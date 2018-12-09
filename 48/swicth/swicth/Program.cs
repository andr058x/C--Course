using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swicth
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Inserisci il premio numero 1");
            string p1 = Console.ReadLine();
            Console.WriteLine("Inserisci il premio numero 2");
            string p2 = Console.ReadLine();
            Console.WriteLine("Inserisci il premio numero 3");
            string p3 = Console.ReadLine();
            Console.WriteLine("Inserisci il premio numero 4");
            string p4 = Console.ReadLine(); ;
            Console.WriteLine("Inserisci il premio numero 5");
            string p5 = Console.ReadLine();
            Console.WriteLine("Inserisci il premio numero 6");
            string p6 = Console.ReadLine();

            Console.WriteLine("Quando sei pronto a lanciare il dado. premi un tasto!");
            Console.ReadKey();
            Random gen_num_casuali = new Random(DateTime.Now.Millisecond);
            int numero_estratto = gen_num_casuali.Next(1, 6);
            Console.WriteLine($"E' stato estratto il numero {numero_estratto}");

            switch(numero_estratto)
            {
                case 1:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p1}\"");

                    break;

                case 2:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p2}\"");

                    break;

                case 3:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p3}\"");

                    break;

                case 4:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p4}\"");

                    break;

                case 5:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p5}\"");

                    break;

                case 6:

                    Console.WriteLine($"Complimenti il tuo premio è il seguente \"{p6}\"");

                    break;

            }

                         
            Console.WriteLine("Premi un tasto per uscire");
            Console.ReadKey();


        }
    }
}
