using System;

namespace ricercanome
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] persone;
            persone = new string[5];

            persone[0] = "MARIO";
            persone[1] = "FABIO";
            persone[2] = "VALENTINA";
            persone[3] = "MARIA";
            persone[4] = "LUISA";

            Console.WriteLine(persone[0]);
            Console.WriteLine(persone[1]);
            Console.WriteLine(persone[2]);
            Console.WriteLine(persone[3]);
            Console.WriteLine(persone[4]);


            int i;
            for (i=0; i<=4; i++)
            {
                Console.WriteLine($"il {i+1} nome e' {persone[i]}");
            }

           
            



            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();
        }
    }
}
