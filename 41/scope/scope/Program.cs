using System;

namespace scope
{
    class Program
    {

        static void test()
        {
            int x = 10; 
            int a = 9;
        }


        static void Main(string[] args)
        {
            test();
            int[] numeri = new int[0];
            
            {
                int a; // 
                Console.WriteLine("Quanti numeri vuoi inserire?");
                int n = Convert.ToInt32(Console.ReadLine());
                numeri = new int[n];
                
                
                for (int i = 0; i < n; i++)
                {
                    //int a;
                    int x = 11; //nasce e muore dentro al ciclo for
                    Console.WriteLine("Inserisci, per favore, l'{i+1}-mo numero");
                    numeri[i] = Convert.ToInt32(Console.ReadLine());
                }
                //i= 9; i non si può più usare dentro qui perchè è morta dopo il for
               // int a;
                a = 33; // a perderà il valore quando uscirà da questo blocco di codice
            }
           // int a = 55;
            a = 33; //a non possiamo più usarla perchè è morta dopo il blocco di codice precedente

            Console.WriteLine($"Premi un tasto per continuare!");
            Console.ReadKey();

            {
                int i;
                int n = numeri.Length;
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"l'{i + 1}-mo numero e': {numeri[i]}");
                    numeri[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Premi un tasto per terminare!");
            Console.ReadKey();
        }
    }
}
