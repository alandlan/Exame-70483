using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo
{
    public class TaskEmpilhada
    {
        /// <summary>
        /// Tasks empilhadas é quando utilizamos mais de uma task 
        /// </summary>
        public static void TaskEmpilhadaMetodo()
        {
            Task<int>[] tarefas = new Task<int>[2];
            tarefas[0] = new Task<int>(() =>
            {
                // faz alguma coisa... 
                return 34;
            });

            tarefas[1] = new Task<int>(() =>
            {
                // faz alguma coisa... 
                return 8;
            });

            var continuation = Task.Factory.ContinueWhenAll(
                            tarefas,
                            (a) =>
                            {
                                int resposta = tarefas[0].Result + tarefas[1].Result;
                                Console.WriteLine("A resposta é {0}", resposta);
                            });

            tarefas[0].Start();
            tarefas[1].Start();
            continuation.Wait();
            Console.ReadKey();
        }
    }
}
