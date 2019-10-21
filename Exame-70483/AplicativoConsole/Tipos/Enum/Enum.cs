using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoConsole.Tipos.Enum
{
    /// <summary>
    /// Enum dias da Semana
    /// </summary>
    public enum Semana
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }

    /// <summary>
    /// Enum de moedas
    /// </summary>
    public enum Moedas
    {
        Euro = 1,
        Dolar = 2,
        Real = 3,
        Libra = 4,
        Peso = 5,
        Soles = 6,
        RandSulAfricano = 7,
        RubloRusso = 8,
        Boliviano = 9,
        RielCambojano = 10,
        Franco = 11,
        PesoChileno = 12,
        KunaCroata = 13,
        PesoCubano = 14
    }

    /// <summary>
    /// Enum Status
    /// </summary>
    public enum Status
    {
        Aprovado = 1,
        Reprovado = 2,
        Aguardando = 3,
        Andamento = 4,
        Erro = 5
    }

    /// <summary>
    /// Enum status
    /// </summary>
    public enum Perfil
    {
        Administrador = 1,
        Usuário = 2,
        MasMegaPower = 3,
        Visitante = 4
    }
}
