using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public class Cliente
    {
        public Cliente(int id = 1, 
                       string nome = "Ciclano da Silva", 
                       string documento = "12345678901", 
                       string sexo = "F")
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            Sexo = sexo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime? DataNascimento { get; set ; }
        public string Sexo { get; set; }
    }
}
