using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo
{
    public class ChamandoTask
    {
        /// <summary>
        /// Chamar uma metodo dentro de uma task
        /// </summary>
        public static void ChamandoTaskMetodo()
        {
            var t = Task.Factory.StartNew(() => FazerAlgo());
            Console.ReadKey();
        }
        static void FazerAlgo()
        {
            Console.WriteLine("executando uma tarefa => FazerAlgo() (task)");
        }
    }
}
