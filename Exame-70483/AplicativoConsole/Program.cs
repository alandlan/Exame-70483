using AplicativoConsole.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Definindo dados do Cliente
            var Dados = new Conta();

            Dados.TipoConta.Id = 1;
            Dados.TipoConta.NomeConta = "Corrente";

            Console.WriteLine(Dados.Cliente.Nome);
            Console.ReadKey();
        }
    }
}
