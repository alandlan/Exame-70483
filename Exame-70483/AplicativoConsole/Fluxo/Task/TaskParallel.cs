﻿using System;
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
    }
}
