using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class Construtor
    {
        private string firstName;
        private string lastName;

        public Construtor()
        {
            var firstName = "Construtor com um Parametro";
        }

        public Construtor(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
