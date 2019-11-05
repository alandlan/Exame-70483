using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo.Lambda
{
    public class Lambda
    {
        public static void LambdaMethod()
        {
            var moedas = new ArrayList(new string[] { "Real", "Dolar", "Euro", "Pesos" });

            //moedas.ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();

            var listMoedas = from string p in moedas where p == "Euro" select p;
            //var listMoedas = moedas.Where(x => x == "Euro");
            
            Console.WriteLine(listMoedas);

            Console.ReadKey();

        }


    }
}
