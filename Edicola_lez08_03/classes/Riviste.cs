using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Edicola_lez08_03.classes
{
    public class Riviste : Libri 
    {
        public string? Codice { get; set; }

        public string? Categoria { get; set; }
        public bool Abbonamento { get; set; }


        public Riviste(string? Titolo, float Prezzo, string? Codice, string? Categoria, bool abbonamento)
        {
            Codice = Codice;
            Categoria = Categoria;
            Abbonamento = abbonamento;
        }

        public override void stampaCaratteristiche()
        {
            Console.WriteLine($"[RIVISTE] {Titolo} {Prezzo} {Codice} {Categoria} {Abbonamento}");

        }
    }
}
