﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo
{
    public class AsyncAwait
    {
        public static void Principal()
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
            ///var lista = new string[2];

            try
            {
                ///string a = lista[2];

                Console.WriteLine("LongRunningOperation() Startedd");
                await Task.Delay(10000); // 2 second delay
                Console.WriteLine("LongRunningOperation() Finished after 2 Seconds");
                return 1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }



        }
    }
}
