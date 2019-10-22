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
            ///String Builder
            StringBuilder myStringBuilder = new StringBuilder("Exame-70843");
            myStringBuilder.Append(" Projeto preparatorio Exame-70843 Programming C#");
            Console.WriteLine(myStringBuilder);

            ///Definindo dados do Cliente
            var Dados = new Conta();

            Dados.TipoConta.Id = 1;
            Dados.TipoConta.NomeConta = "Corrente";

            Console.WriteLine($"Saldo atual : {0} ", Dados.Saldo);
            Console.ReadKey();

            Dados.Sacar(400);
            Console.WriteLine($"Saldo após saque : {0}",Dados.Saldo);
            Console.ReadKey();

        }
    }
}
