using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    public class TiposValor
    {
        /// <summary>
        /// Int 
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public byte IdExterno { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public char Tipo { get; private set; }
        public decimal Valor { get; private set; }
        public double ValorTotal { get; private set; }
        public float Percentual { get; private set; }
        public long Posicao { get; private set; }
        public sbyte Hanking { get; private set; }
        public short HankingContinental { get; private set; }
        public struct ListaTarefas { };
        public uint HankingGlobal { get; private set; }
        public ulong HankingUniversal { get; private set; }
        public ushort HankingEstadual { get; private set; }

        public TiposValor(int id, byte idExterno, char tipo, decimal valor, double valorTotal, float percentual, long posicao, sbyte hanking, short hankingContinental, uint hankingGlobal, ulong hankingUniversal, ushort hankingEstadual)
        {
            Id = id;
            IdExterno = idExterno;
            Tipo = tipo;
            Valor = valor;
            ValorTotal = valorTotal;
            Percentual = percentual;
            Posicao = posicao;
            Hanking = hanking;
            HankingContinental = hankingContinental;
            HankingGlobal = hankingGlobal;
            HankingUniversal = hankingUniversal;
            HankingEstadual = hankingEstadual;
        }
    }
}