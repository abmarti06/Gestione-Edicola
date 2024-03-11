using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.classes
{
    public class Giornale : Libri 
    {
        public string? Redazione { get; set; }

        public bool hasInserto { get; set; }

        public Giornale (string? Titolo, float Prezzo, string? Redazione, bool hasInserto)
        {
            Titolo = Titolo;
            Prezzo = Prezzo; 
            Redazione = Redazione;
            this.hasInserto = hasInserto;
            
        }

        public override void stampaCaratteristiche()
        {
            Console.WriteLine($"[GIORNALI] {Titolo} {Prezzo} {Redazione} {hasInserto}");
        }
    }
}
