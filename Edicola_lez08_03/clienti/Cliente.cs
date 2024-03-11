using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edicola_lez08_03.clienti
{
    internal class Cliente
    {
        protected string? Nome { get; set; }
        protected string? CodiceCliente { get; set; }
        public bool hasAbbonamentoRivista { get; set; }


        public Cliente (string? nome, string? codiceCliente, bool hasAbbonamento)
        {
            Nome = nome;
            CodiceCliente = codiceCliente;
            this.hasAbbonamentoRivista = hasAbbonamento;
        }

        public void caratteristicheCliente()
        {
            Console.WriteLine($"[CLIENTE] {Nome} {CodiceCliente}");
        }
    }
}
