using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.classes
{
    internal class Edicola
    {
        public string? Indirizzo { get; set; }
        public string? Nome { get; set; }


        public List<Libri> magazzino { get; set; } = new List<Libri>();

        
        public Edicola(string? Indirizzo, string? Nome)
        {
            Indirizzo = Indirizzo;
            Nome = Nome; 

        }

        public void aggiungere(Libri book)
        {
            magazzino.Add(book);
        }

        public void rimuovere(Libri book)
        {
            magazzino.Remove(book);
        }


        public void stampaCaratteristiche()
        {
            Console.WriteLine("i libri sono:");
            foreach (Libri book in magazzino)
            {
                book.stampaCaratteristiche();
            }
        }

        public void DettagliMagazzino()
        {
            while (true)
            {
                Console.WriteLine("1. VENDITE");
                Console.WriteLine("2. RICERCA E FILTRAGGIO");
                Console.WriteLine("3. GESTIONE SOTTOSCRIZIONI");

                Console.Write("la tua scelta è:");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Vendite();
                        break;
                    case "2":
                        RicercaEFiltraggio();
                        break;
                    case "3":
                        GestioneSottoscrizioni();
                        break;
                    default:
                        Console.WriteLine("hai sbagliato, riprova");
                        break;

                }

                static void Vendite()
                {

                }


                static void RicercaEFiltraggio()
                {

                }


                static void GestioneSottoscrizioni()
                {

                }
            }
        }
       

    }
        
}
