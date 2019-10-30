using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo.Multithread
{
    public class Multithread
    {
        /// <summary>
        /// Multitread permite utilizar varios metodos simultanemente
        /// </summary>
        public static void Principal()
        {
            // dispara uma nova thread para executar
            Thread t = new Thread(NovaThread);
            t.Start();

            // Simultaneamente, executa uma tarefa na thread principal
            for (int i = 0; i < 10000; i++) Console.Write("1");
        }

        public static void NovaThread()
        {
            for (int i = 0; i < 10000; i++) Console.Write("2");
        }
    }
}
