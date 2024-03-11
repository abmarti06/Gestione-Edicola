using Edicola_lez08_03.classes;
using Edicola_lez08_03.clienti;
using System.Reflection.Metadata.Ecma335;

namespace Edicola_lez08_03
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Libri giorn = new Giornale("Giornale 1", 1.50f, "RedazioneA", false); 
            Libri giorn2 = new Giornale("Giornale 2", 1.80f, "RedazioneB", false); 
            Libri giorn3 = new Giornale("Giornale 3", 2.50f, "RedazioneC", false);

            Libri riv = new Riviste("Rivista 1", 3.20f, "AB12345", "Horror", true);
            Libri riv2 = new Riviste("Rivista 2", 5.60f, "CD12345", "Romance", false);
            Libri riv3 = new Riviste("Rivista 3", 2.20f, "EF12345", "Cucina", false);

            Edicola edi = new Edicola("Via Roma, 30", "Kiosk");


            Cliente cli = new Cliente("Gianluca", "GL1234", true); 
            Cliente cli2 = new Cliente("Sofia", "SF3456", false); 
            Cliente cli3 = new Cliente("Maria", "MR6789", false); 


            edi.aggiungere(giorn);
            edi.aggiungere(giorn2);
            edi.aggiungere(giorn3);
            edi.aggiungere(riv);
            edi.aggiungere(riv2);
            edi.aggiungere(riv3);

    }
    }
}
