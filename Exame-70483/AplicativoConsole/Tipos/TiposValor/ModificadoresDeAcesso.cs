namespace Tipos
{
    /// <summary>
    /// Modificadores de acesso do C#
    /// </summary>
    public class ModificadoresAcesso
    {
        /// <summary>
        /// O acesso não é restrito.
        /// </summary>
        public string Public { get; set; }

        /// <summary>
        /// O acesso é limitado ao tipo recipiente
        /// </summary>
        private string Private { get; set; }

        /// <summary>
        ///  O acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual.
        /// </summary>
        //private protected string PrivateProtected { get; set; }

        /// <summary>
        /// O acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
        /// </summary>
        protected string Protected { get; set; }

        /// <summary>
        /// O acesso é limitado ao assembly atual
        /// </summary>
        internal string Internal { get; set; }

        /// <summary>
        /// O acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.

        /// </summary>
        protected internal string ProtectedInternal { get; set; }


    }
}