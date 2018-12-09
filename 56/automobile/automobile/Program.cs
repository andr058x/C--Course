using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobile
{
    class Program
    {
        public class automobile //Definiamo la classe automobile dove abbiamo delle variabili private
        {
            private string marca; 
            private string modello;
            private string colore;
            private int cilindrata;


            public static bool marca_valida(string m)
            {
                m = m.ToUpper();
                if (m == "" || m == "FIAT" || m == "ALFA ROMEO" || m == "FERRARI" || m == "MITSUBISHI")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool cilindrata_valida(int c)
            {
                if (c >= 0 && c < 4000)
                { 
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public static bool modello_valido_per_marca(string mod, string marca)
            {
                mod = mod.ToUpper();
                marca = marca.ToUpper();
                if (mod == "" || (mod == "PUNTO" && marca == "FIAT") || (mod == "PANDA" && marca == "FIAT") || (mod == "TESTA ROSSA" && marca == "FERRARI") || (mod == "PAJERO" && marca == "MITSUBISHI"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool colore_valido(string col)
            {
                col = col.ToUpper();
                if (col == "ROSSO" || col == "NERO" || col == "BIANCO" || col == "GRIGIO METALIZZATO" || col == "BLUE" || col == "MARRONE" || col == "VERDE" || col == "ARANCIO" || col == "GIALLO")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public automobile()
            {
                this.set_marca("");
                this.set_modello("");
                this.set_cilindrata(0);
                this.set_colore("");
            }

            public bool set_marca(string m)
            {
                m = m.ToUpper();
                if (automobile.marca_valida(m))
                {
                    this.marca = m;
                    this.set_modello("");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public string get_marca()
            {
                return this.marca;
            }

            public bool set_modello(string mod)
            {
                mod = mod.ToUpper();
                if (this.modello_valido(mod))
                {
                    this.modello = mod;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string get_modello()
            {
                return this.modello;
            }
            public bool set_cilindrata(int c)
            {
                if (automobile.cilindrata_valida(c))
                {
                    this.cilindrata = c;
                    return true;
                }
                else
                {
                    return false;
                }
            }


            public int get_cilindrata()
            {
                return this.cilindrata;
            }
            public bool set_colore(string col)
            {
                col = col.ToUpper();
                if (automobile.colore_valido(col))
                {
                    this.colore = col;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public string get_colore()
            {
                return this.colore;
            }

            public bool modello_valido(string mod)
            {
                if(automobile.modello_valido_per_marca(mod, this.marca))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void stampa_a_video()
            {
                Console.WriteLine($"MARCA: {this.marca}");
                Console.WriteLine($"MODELLO: {this.modello}");
                Console.WriteLine($"CILINDRATA: {this.cilindrata}");
                Console.WriteLine($"COLORE: {this.colore}");
            }

        }
        static void Main(string[] args)
        {
            automobile auto = new automobile();
            auto.set_marca("FIAT");
            auto.set_modello("PANDA");
            auto.set_colore("VERDE");
            auto.set_cilindrata(3000);
            Console.WriteLine("Premi un tasto");
            Console.ReadKey();        
            Console.WriteLine("RIEPILOGO");
            Console.WriteLine($"MARCA: {auto.get_marca()}");
            Console.WriteLine($"MODELLO: {auto.get_modello()}");
            Console.WriteLine($"CILINDRATA: {auto.get_cilindrata()}");
            Console.WriteLine($"COLORE: {auto.get_colore()}");
            Console.WriteLine("Premi un tasto");
            Console.ReadKey();
            Console.WriteLine("Adesso i dati dell'auto li inserirati TU");

            string marca;
            do
            {
                Console.WriteLine("Inserisci la marca");
                
                marca = Console.ReadLine().ToUpper();
                if (automobile.marca_valida(marca))
                {
                    auto.set_marca(marca);
                }
                else
                {
                    Console.WriteLine("MARCA INSERITA NON VALIDA");
                }
            } while (!automobile.marca_valida(marca));

            string modello;
            do
            {
                Console.WriteLine("Inserisci il modello");
                modello = Console.ReadLine().ToUpper();
                if (automobile.modello_valido_per_marca(modello, marca))
                {
                    auto.set_modello(modello);
                }
                else
                {
                    Console.WriteLine("MODELLO INSERITO NON VALIDO");
                } 
            } while (!automobile.modello_valido_per_marca(modello, marca));

            int cilindrata;
            do
            {
                Console.WriteLine("Insersci la cilindrata");
                cilindrata = Convert.ToInt32(Console.ReadLine());
                if (automobile.cilindrata_valida(cilindrata))
                {
                    auto.set_cilindrata(cilindrata);
                }
                else
                {
                    Console.WriteLine("CILINDRATA NON VALIDA");
                }
            } while (!automobile.cilindrata_valida(cilindrata));

            string colore;
            do
            {
                Console.WriteLine("Inserisci il colore");
                colore = Console.ReadLine().ToUpper();
                if (automobile.colore_valido(colore))
                {
                    auto.set_colore(colore);
                }
                else
                {
                    Console.WriteLine("COLORE NON VALIDO");
                }

            } while (!automobile.colore_valido(colore));

            Console.WriteLine("Premi un tasto");
            Console.ReadKey();
            Console.WriteLine("RIEPILOGO");
            auto.stampa_a_video();

            Console.WriteLine("Premi un tasto per terminare");
            Console.ReadKey();



        }
    }
}
