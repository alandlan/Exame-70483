using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class Conta
    {
        public int Id { get; set; }
        public Enum TipoConta { get; set; }
        public int Cliente { get; set; }
        public decimal Saldo { get; set; }
    }
}
