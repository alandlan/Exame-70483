using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Acesso_dados
{
    public class FluxoEntradaSaida
    {
        /// <summary>
        /// Método trabalha com diretórios, lista, cria e consulta diretório
        /// </summary>
        public void TrabalhandoComDiretorios()
        {
            var diretorio = @"C:\\XPTO";
            var file = @"C:\\XPTO\\LogErros.txt";

            // verifica se tem o diretório e o arquivo
            if (!Directory.Exists(diretorio))
            {
                // se não existir cria o diretorio
                Directory.CreateDirectory(diretorio);
                File.Create(file);
            }
            else
            {
                Console.WriteLine("Essa pasta já existe!");
                return;
            }

            var fileInfo = new FileInfo(file);
            Console.WriteLine("Nome: {0}", fileInfo.Name);
            Console.WriteLine("Extensão: {0}", fileInfo.Extension);
            Console.WriteLine("Data da criação: {0}", fileInfo.CreationTime);
            Console.WriteLine("Diretório: {0}", fileInfo.Directory);
            Console.ReadKey();
        }
    }
}
