﻿using AplicativoConsole.Fluxo;
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
                       
            ///Exibe o Saldo definido no Construtor
            Console.WriteLine("Saldo atual : {0} ", Dados.Saldo);
            Console.ReadKey();

            ///Metodo para sacar
            Dados.Sacar(400);
            Console.WriteLine("Saldo após saque : {0}",Dados.Saldo);
            Console.ReadKey();

            ///Metodo de extensão
            var Frase = "Metodos de Extensão?!";
            Console.WriteLine("Frase antes do Metodo Extensao: {0}", Frase);
            Console.ReadKey();

            int i = Frase.MudarPalavra();

            Console.WriteLine("Frase após do Metodo Extensao : {0}", i);
            Console.ReadKey();

            //Esse exemplo é com método Opcional
            Console.WriteLine("Antes de Investir : {0}", Dados.Saldo);
            Console.ReadKey();
            Dados.Saldo = Dados.ValorInvestido(Dados.Saldo, 2000);
            Console.WriteLine("Depois de Investir(valor passado 2000) : {0}", Dados.Saldo);
            Console.ReadKey();

            Dados.Saldo = Dados.ValorInvestido(Dados.Saldo);
            Console.WriteLine("Depois de Investir(valor não passado deve assumir 5000) : {0}", Dados.Saldo);
            Console.ReadKey();
            //Fim do exemplo com método Opcional

            var construtor = new Construtor();

            /// <summary>
            /// Exemplos de Task
            /// </summary>
            
                ///Chamada assincrona de Task
                TaskParallel.TaskParallell();
                Console.ReadKey();

                ///Chamada de uma task por outra task
                ChamandoTask.ChamandoTaskMetodo();
                Console.ReadKey();

                //Chamada de tasks 
                TaskEmpilhada.TaskEmpilhadaMetodo();

                //Usando o async e await com Tasks
                AsyncAwait.Principal();
                Console.ReadKey();

            // Fim de exemplo de tasks

        }
    }
}
