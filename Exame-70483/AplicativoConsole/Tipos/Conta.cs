using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class Conta
    {
        public Conta(int id = 1, int cliente = 1, decimal saldo = 5000, int tipoContaId = 1)
        {
            Id = id;
            IdCliente = cliente;
            Saldo = saldo;
            TipoContaId = tipoContaId;
            TipoConta = new TipoConta();
            Cliente = new Cliente();
        }

        public int Id { get; set; }
        public decimal Saldo { get; set; }

        public int TipoContaId { get; set; }
        public TipoConta TipoConta { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

    }
}
