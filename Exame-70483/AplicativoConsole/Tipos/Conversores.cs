using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class Conversores
    {
        /// <summary>
        /// De 
        /// </summary>
        public class ConversorImplicito
        {
            // conversoes De para e nunca Para para De
            // ex; de Float para Double e nao de Double Float
            public double Converter(double valor)
            {
                return valor;
            }
        }

        public class ConversoExplicito
        {
            public float Converter(double valor)
            {
                float valorNovo = (float)valor;

                int valorNovo2 = Convert.ToInt32(valor);


                double valorNovo3 = Double.Parse("123");


                return valorNovo;
            }
        }

        /*
        int 16 = suporta os valores de −32,768 até +32,767
        int 32 = suporta os valores de −2,147,483,648 até +2,147,483,647
        int 64 = suporta os valores de −9,223,372,036,854,775,808 até +9,223,372,036,854,775,807 
        */
    }
}

