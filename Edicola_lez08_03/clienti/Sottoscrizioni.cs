using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.clienti
{
    internal class Sottoscrizioni 
    {
        static void Abbonamenti()
        {
            Console.WriteLine("Chi dei tuoi clienti ha l'abbonamento? 1.Gianluca, 2.Sofia, 3.Maria");
            string nomiClienti= Console.ReadLine();
            switch (nomiClienti)
            {
                case "Gianluca":
                    Console.WriteLine("Gianluca");
                    break;
                case "Sofia":
                    Console.WriteLine("Sofia");
                    break;
                case "Maria":
                    Console.WriteLine("Maria");
                    break;
                default:
                    Console.WriteLine("hai sbagliato, riprova");
                    break;
            }

        }
    }
}
