using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo
{
    public class TaskParallel
    {

        public static void TaskParallell()
        {
            
                Thread.CurrentThread.Name = "Main";

                // Create a task and supply a user delegate by using a lambda expression. 
                Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
                // Start the task.
                taskA.Start();

                // Output a message from the calling thread.
                Console.WriteLine("Hello from thread '{0}'.",
                                  Thread.CurrentThread.Name);
            
                taskA.Wait(); 
        }

        /// <summary>
        /// Chamar uma metodo dentro de uma task
        /// </summary>
        public static void ChamandoTask()
        {
            var t = Task.Factory.StartNew(() => FazerAlgo());
            Console.ReadKey();
        }
        static void FazerAlgo()
        {
            Console.WriteLine("executando uma tarefa => FazerAlgo() (task)");
        }


        public static void TaskEmpilhada()
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

        public static void Mainn()
        {
            var a = MyMethodAsync(); //Task started for Execution and immediately goes to Line 19 of the code. Cursor will come back as soon as await operator is met		
            Console.WriteLine("Cursor Moved to Next Line Without Waiting for MyMethodAsync() completion.");
            Console.WriteLine("Now Waiting for Task to be Finished");
            Task.WaitAll(a); //Now Waiting		
            Console.WriteLine("Exiting CommandLine");
        }

        public static async Task MyMethodAsync()
        {
            //int longRunningTask = await LongRunningOperation();
            Task<int> longRunningTask = LongRunningOperation();

            // independent work which doesn't need the result of LongRunningOperationAsync can be done here
            Console.WriteLine("Independent Works of now executes in MyMethodAsync()");
            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine("Result of LongRunningOperation() is " + result);
        }

        public static async Task<int> LongRunningOperation() // assume we return an int from this long running operation 
        {
            var lista = new string[2];

            try
            {
                string a = lista[3];

                Console.WriteLine("LongRunningOperation() Startedd");
                await Task.Delay(10000); // 2 second delay
                Console.WriteLine("LongRunningOperation() Finished after 2 Seconds");
                return 1;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
               
            }

           
            
        }

    }
}
