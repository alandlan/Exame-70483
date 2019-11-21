using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.FluxoEntradaSaida.HttpTransfer
{
    public class HttpTransfer
    {
        public static void Http()
        {
            string url = "http://www.macoratti.net/Default.aspx";
            var a = DownloadAsync(url);
            Console.ReadLine();
        }
        static async Task DownloadAsync(string url)
        {
            Uri uri = new Uri(url);
            // cria uma instância de webclient
            using (WebClient cliente = new WebClient())
            {
                // OBTEM O CONTEÚDO DO ARQUIVO
                Console.WriteLine($"Downloading {uri.AbsoluteUri}");
                // faz o download da pagina e armazena em um array de bytes
                byte[] bytes;
                try
                {
                    // Existe também o método DownloadDataAsync 
                    bytes = await cliente.DownloadDataTaskAsync(uri);
                }
                catch (WebException we)
                {
                    Console.WriteLine(we.ToString());
                    return;
                }
                // Escreve a saida HTML
                string page = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(page);
            }
        }

    }
}