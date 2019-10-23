using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos
{
    public static class MinhaExtensao
    {
        public static int MudarPalavra(this string str)
        {
            return str.Split(new char[] { '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
