using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.clienti
{
    internal class Vendite 


    {
        static void venditaGiornale()
        {

            Console.WriteLine("Quanti giornali hanno acquistato i clienti?");
            string acquistoGiornale = Console.ReadLine();
            int num = int.Parse(acquistoGiornale);
            Console.WriteLine($"i giornali acquistati sono {acquistoGiornale}");

            if (acquistoGiornale is not null)
            {
                Console.WriteLine("i clienti hanno acquistato dalla tua edicola");
            }
            else
            {
                Console.WriteLine("Mi dispiace, nessuna vendita");
            }
        }

        static void venditaRivista()
        {
            Console.WriteLine("Quanti giornali hanno acquistato i clienti?");
            string acquistoRivista = Console.ReadLine();
            int num2=int.Parse(acquistoRivista);
            Console.WriteLine($"le riviste acquistate sono {acquistoRivista}");

            if (acquistoRivista is not null)
            {
                Console.WriteLine("i clienti hanno acquistato dalla tua edicola");
            }
            else
            {
                Console.WriteLine("Mi dispiace, nessuna vendita");
            }

        }



        
    }
}
