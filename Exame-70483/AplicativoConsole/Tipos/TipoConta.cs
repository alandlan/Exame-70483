using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class TipoConta
    {
        public TipoConta(int id = 1, string nomeconta = "Corrente")
        {
            Id = id;
            NomeConta = nomeconta;
        }
        /// <summary>
        /// Id da Conta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da Conta
        /// </summary>
        public string NomeConta { get; set; }
    }
}
