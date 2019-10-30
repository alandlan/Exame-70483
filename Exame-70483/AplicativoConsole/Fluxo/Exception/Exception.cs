using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo.Exceptionn
{
    public class ExceptionClass
    {
        public static (int a, List<string> issoLista) Teste(int a, string b) => (a + 1, new List<string>());

        public static void ExceptionArithmetic(int x)
        {
            //int x = 0;
            try
            {
                int y = 100 / x;

                var t = Teste(1, "");

                Console.WriteLine(t.a);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }

       

        public string teste()
        {
            return "";
        }

        public static void ExceptionNull()
        {
            var pessoa = new Pessoa();
//            pessoa = null;
            try
            {
                var umaPessoa = pessoa?.Nome;
                int umaPessoaIdade = pessoa.Idade;

                //if (umaPessoa == null)
                //throw new NullReferenceException($"Exception");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Exception null: {e}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }
        }
    }

    internal class Pessoa
    {
        public string Nome { get; set; } = null;
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
    }


   
}
