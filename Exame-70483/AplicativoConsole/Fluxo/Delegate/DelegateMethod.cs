using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Fluxo.DelegateMethod
{
    

    public class MethodDelegate
    {

        public delegate void MeuDelegate(int texto);
        public delegate int MeuDelegateSemParametro();

        private void MeuMetodo(int texto)
        {
            Console.WriteLine(texto);
        }

        public void ChamarDelegate()
        {
            MeuDelegate meuDelegate = new MeuDelegate(MeuMetodo);
            meuDelegate(1);
        }

        private int MeuMetodoSemParametro()
        {
            Console.WriteLine("Delegate sem parametros.");

            return 1;
        }

        public int ChamarDelegateSemparametro()
        {
            MeuDelegateSemParametro meuDelegate = new MeuDelegateSemParametro(MeuMetodoSemParametro);
            int a = meuDelegate();

            return a;
        }

    }






}
