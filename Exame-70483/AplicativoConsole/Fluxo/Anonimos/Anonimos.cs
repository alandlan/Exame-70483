using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo.Anonimos
{
    public class Anonimos
    {
        public void MethodoAnonimo()
        {
            List<int> numeros = new List<int> { 1, 2, 4, 5, 7, 8, 9, 12, 54, 467 };
            List<int> Resultado = numeros.Where(x => x % 2 == 0).ToList();

            foreach (var n in Resultado)
            {
                Console.WriteLine("Impares "+ n );
            }

        }


    }
}
