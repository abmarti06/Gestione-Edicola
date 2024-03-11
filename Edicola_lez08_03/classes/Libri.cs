using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.classes
{
    public abstract class Libri
    {
        protected string? Titolo {  get; set; }
        protected float? Prezzo { get; set; }


        public abstract void stampaCaratteristiche();

        


        
    }
}
